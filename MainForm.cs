using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Rectangles
{
    public partial class MainForm : Form
    {
        List<Rectangle> BlueRectangles, RedRectangles, Rectangles;
        List<Point> BluePoints, RedPoints;
        CancellationTokenSource cts = new CancellationTokenSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BlueRectangles = new List<Rectangle>();
            RedRectangles = new List<Rectangle>();
            Rectangles=new List<Rectangle>();
            BluePoints = new List<Point>();
            RedPoints = new List<Point>();
            drawingPanel.Focus();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Rectangle blue in BlueRectangles)
            {
                using (Graphics g = drawingPanel.CreateGraphics())
                {
                    SolidBrush brush = new SolidBrush(Color.Blue);
                    g.FillEllipse(brush, blue);
                    brush.Dispose();
                }
            }

            foreach (Rectangle red in RedRectangles)
            {
                using (Graphics g = drawingPanel.CreateGraphics())
                {
                    SolidBrush brush = new SolidBrush(Color.Red);
                    g.FillEllipse(brush, red);
                    brush.Dispose();
                }
            }

            foreach (Rectangle rec in Rectangles)
            {
                using (Graphics g = drawingPanel.CreateGraphics())
                {
                    g.DrawRectangle(new Pen(Color.Black, 2), rec);
                }
            }
        }

        private void ClearBlueButton_Click(object sender, EventArgs e)
        {
            BlueRectangles.Clear();
            BluePoints.Clear();
            drawingPanel.Invalidate();
        }

        private void ClearRedButton_Click(object sender, EventArgs e)
        {
            RedRectangles.Clear();
            RedPoints.Clear();
            drawingPanel.Invalidate();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            StartButton.Enabled = true;
            ResetButton.Enabled = true;
            StopButton.Enabled = false;
            drawingPanel.Invalidate();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            ResetButton.Enabled = false;
            StopButton.Enabled = true;
            SetProgress(0);
            ResultsRichTextBox.Text = "";
            cts = new CancellationTokenSource();
            Task t = new Task(new Action(SA), cts.Token);
            t.Start();
        }

        private void SA()
        {
            int m = (int)nRectangleNumericUpDown.Value, // no. of rectangles
                nBlue = BluePoints.Count,
                nRed = RedPoints.Count,
                n = nBlue + nRed, // total no. of points
                MaxTrial = 500, // no. of trials at each temperature
                Tsteps = 100, // no. of steps to cool-down the system
                progress = 0; // progress indicator, 0-100
            Rectangles = new List<Rectangle>();
            int[] minState;

            Random rand = new Random(); // initialize rng

            // initial guess
            int[] state = new int[nBlue];
            for (int i = 0; i < nBlue; i++)
            {
                state[i] = rand.Next(m + 1);
            }
            // calculate initial energy
            int E = Energy(state, m),
                minE = E;
            minState = (int[])state.Clone();

            double kT = 0.1*n, // initial temperature
                kT_f = 0.001 * n, // final temperature
                dT = (kT - kT_f) / Tsteps;

            int step = 0;
            AppendResult(" Step        kT        E");
            AppendResult(string.Format("{0,5:#,#####0}   {1,9:#,##0.00}   {2,6:#,#####0}", step, kT, minE));

            while (step< Tsteps && !cts.IsCancellationRequested)
            {
                // perform MaxTrial iterations at the current temperature
                int iter = 0;
                while (iter<MaxTrial && !cts.IsCancellationRequested)
                {
                    // generate a new state by randomly changing a cell
                    int p = rand.Next(state.Length);
                    int[] newState = (int[])state.Clone();
                    while (newState[p] == state[p])
                    {
                        newState[p] = rand.Next(m + 1);
                    }

                    // calculate energy
                    int E_new = Energy(newState, m);
                    if(rand.NextDouble()<-(E_new-E)/kT)
                    {
                        state[p] = newState[p];
                        E = E_new;
                    }
                    if(E < minE)
                    {
                        minState = (int[])state.Clone();
                        minE = E;
                    }
                    iter++;
                }

                progress += 100 / Tsteps;
                SetProgress(progress);

                kT -= dT;
                step++;
                // display results
                AppendResult(string.Format("{0,5:#,#####0}   {1,9:#,##0.00}   {2,6:#,#####0}", step, kT, minE));
            }

            // build rectangles for drawing
            Rectangles = GenerateRectangles(minState, m);
            for (int i = 0; i < Rectangles.Count; i++)
            {
                Rectangle r = Rectangles[i];
                if (r.Width == 0)
                {
                    r.X -= 7;
                    r.Width = 14;
                }
                if (r.Height == 0)
                {
                    r.Y -= 7;
                    r.Height = 14;
                }
                Rectangles[i] = r;
            }

            // perform click on the stop button
            this.Invoke(new Action(() => { StopButton.PerformClick(); }));
        }

        private List<Rectangle> GenerateRectangles(int[] state, int m)
        {
            List<Rectangle> rec = new List<Rectangle>();
            for (int i = 0; i < m; i++)
            {
                List<int> x = new List<int>(),
                    y = new List<int>();

                for (int j = 0; j < state.Length; j++)
                {
                    if(state[j]==i+1)
                    {
                        x.Add(BluePoints[j].X);
                        y.Add(BluePoints[j].Y);
                    }
                }

                if (x.Count < 1)
                    continue;

                // determine the two extremes of rectangle
                int minX = x.ToArray().Min(),
                    maxX = x.ToArray().Max(),
                    minY = y.ToArray().Min(),
                    maxY = y.ToArray().Max();
                rec.Add(new Rectangle(minX, minY, maxX - minX, maxY - minY));
            }
            return rec;
        }

        // calculation of energy (objective function)
        private int Energy(int[] state, int m)
        {
            List<Rectangle> rec = GenerateRectangles(state, m);
            int E = 0;
            foreach (Point p in RedPoints)
            {
                foreach (Rectangle r in rec)
                {
                    if (isInside(p, r))
                    {
                        E++;
                        break;
                    }
                }
            }
            foreach (Point p in BluePoints)
            {
                foreach (Rectangle r in rec)
                {
                    if (isInside(p, r))
                    {
                        E--;
                        break;
                    }
                }
            }
            return E;
        }

        // check if the point p is inside the rectangle region r
        private bool isInside (Point p, Rectangle r)
        {
            if (p.X<r.X || p.Y<r.Y || p.X>r.X+r.Width || p.Y>r.Y+r.Height)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BlueRectangles = new List<Rectangle>();
            RedRectangles = new List<Rectangle>();
            Rectangles = new List<Rectangle>();
            BluePoints = new List<Point>();
            RedPoints = new List<Point>();
            drawingPanel.Invalidate();
        }

        private void RandPointsButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Second);
            int D = 10; // diameter of ellipse
            while (BlueRectangles.Count < (int)BlueNumericUpDown.Value)
            {
                int x = rand.Next(1, drawingPanel.Width),
                    y = rand.Next(1, drawingPanel.Height);
                BluePoints.Add(new Point(x, y));
                BlueRectangles.Add(new Rectangle(x - D / 2, y - D / 2, D, D));
            }

            while (RedRectangles.Count < (int)RedNumericUpDown.Value)
            {
                int x = rand.Next(1, drawingPanel.Width),
                    y = rand.Next(1, drawingPanel.Height);
                RedPoints.Add(new Point(x, y));
                RedRectangles.Add(new Rectangle(x - D / 2, y - D / 2, D, D));
            }
            drawingPanel.Invalidate();
        }

        private void AppendResult(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendResult), new object[] { value });
                return;
            }
            ResultsRichTextBox.Text += value + "\n";
            ResultsRichTextBox.Select(ResultsRichTextBox.Text.Length - 1, 0);
            ResultsRichTextBox.ScrollToCaret();
        }

        private void SetProgress(int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<int>(SetProgress), new object[] { value });
                return;
            }
            progressBar1.Value = value;
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int D = 10; // diameter of ellipse
                if (BlueRadioButton.Checked && BlueRectangles.Count < (int)BlueNumericUpDown.Value)
                {
                    BluePoints.Add(new Point(e.X, e.Y));
                    BlueRectangles.Add(new Rectangle(e.X - D / 2, e.Y - D / 2, D, D));
                    drawingPanel.Invalidate();
                }

                if (RedRadioButton.Checked && RedRectangles.Count < (int)RedNumericUpDown.Value)
                {
                    RedPoints.Add(new Point(e.X, e.Y));
                    RedRectangles.Add(new Rectangle(e.X - D / 2, e.Y - D / 2, D, D));
                    drawingPanel.Invalidate();
                }
            }
        }

    }

}



















































