namespace Rectangles
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.nRectangleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClearRedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearBlueButton = new System.Windows.Forms.Button();
            this.BlueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.RandPointsButton = new System.Windows.Forms.Button();
            this.controlsPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRectangleNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueNumericUpDown)).BeginInit();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawingPanel.Location = new System.Drawing.Point(0, 24);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(737, 392);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.groupBox4);
            this.controlsPanel.Controls.Add(this.groupBox3);
            this.controlsPanel.Controls.Add(this.groupBox2);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(0, 416);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(737, 139);
            this.controlsPanel.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ResultsRichTextBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(354, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(383, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // ResultsRichTextBox
            // 
            this.ResultsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsRichTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.ResultsRichTextBox.Name = "ResultsRichTextBox";
            this.ResultsRichTextBox.ReadOnly = true;
            this.ResultsRichTextBox.Size = new System.Drawing.Size(377, 120);
            this.ResultsRichTextBox.TabIndex = 0;
            this.ResultsRichTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResetButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.StopButton);
            this.groupBox3.Controls.Add(this.StartButton);
            this.groupBox3.Controls.Add(this.nRectangleNumericUpDown);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(175, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculation";
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(123, 42);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(49, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(9, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(163, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 4;
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(66, 42);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(49, 23);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(9, 42);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(49, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // nRectangleNumericUpDown
            // 
            this.nRectangleNumericUpDown.Location = new System.Drawing.Point(105, 19);
            this.nRectangleNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nRectangleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRectangleNumericUpDown.Name = "nRectangleNumericUpDown";
            this.nRectangleNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.nRectangleNumericUpDown.TabIndex = 1;
            this.nRectangleNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "No. of Rectangles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RandPointsButton);
            this.groupBox2.Controls.Add(this.RedNumericUpDown);
            this.groupBox2.Controls.Add(this.ClearRedButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ClearBlueButton);
            this.groupBox2.Controls.Add(this.BlueNumericUpDown);
            this.groupBox2.Controls.Add(this.RedRadioButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BlueRadioButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Mode";
            // 
            // RedNumericUpDown
            // 
            this.RedNumericUpDown.Location = new System.Drawing.Point(109, 37);
            this.RedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RedNumericUpDown.Name = "RedNumericUpDown";
            this.RedNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.RedNumericUpDown.TabIndex = 3;
            this.RedNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ClearRedButton
            // 
            this.ClearRedButton.Location = new System.Drawing.Point(97, 112);
            this.ClearRedButton.Name = "ClearRedButton";
            this.ClearRedButton.Size = new System.Drawing.Size(75, 23);
            this.ClearRedButton.TabIndex = 3;
            this.ClearRedButton.Text = "Clear Red";
            this.ClearRedButton.UseVisualStyleBackColor = true;
            this.ClearRedButton.Click += new System.EventHandler(this.ClearRedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. of red points";
            // 
            // ClearBlueButton
            // 
            this.ClearBlueButton.Location = new System.Drawing.Point(97, 89);
            this.ClearBlueButton.Name = "ClearBlueButton";
            this.ClearBlueButton.Size = new System.Drawing.Size(75, 23);
            this.ClearBlueButton.TabIndex = 2;
            this.ClearBlueButton.Text = "Clear Blue";
            this.ClearBlueButton.UseVisualStyleBackColor = true;
            this.ClearBlueButton.Click += new System.EventHandler(this.ClearBlueButton_Click);
            // 
            // BlueNumericUpDown
            // 
            this.BlueNumericUpDown.Location = new System.Drawing.Point(109, 14);
            this.BlueNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.BlueNumericUpDown.Name = "BlueNumericUpDown";
            this.BlueNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.BlueNumericUpDown.TabIndex = 1;
            this.BlueNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(9, 115);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(77, 17);
            this.RedRadioButton.TabIndex = 1;
            this.RedRadioButton.Text = "Red Points";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. of blue points";
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.AutoSize = true;
            this.BlueRadioButton.Checked = true;
            this.BlueRadioButton.Location = new System.Drawing.Point(9, 92);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(78, 17);
            this.BlueRadioButton.TabIndex = 0;
            this.BlueRadioButton.TabStop = true;
            this.BlueRadioButton.Text = "Blue Points";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drawing Area";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPanel
            // 
            this.labelPanel.Controls.Add(this.label1);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(737, 24);
            this.labelPanel.TabIndex = 3;
            // 
            // RandPointsButton
            // 
            this.RandPointsButton.Location = new System.Drawing.Point(9, 60);
            this.RandPointsButton.Name = "RandPointsButton";
            this.RandPointsButton.Size = new System.Drawing.Size(159, 22);
            this.RandPointsButton.TabIndex = 4;
            this.RandPointsButton.Text = "Random Points";
            this.RandPointsButton.UseVisualStyleBackColor = true;
            this.RandPointsButton.Click += new System.EventHandler(this.RandPointsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 555);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.labelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Rectangles";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.controlsPanel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRectangleNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueNumericUpDown)).EndInit();
            this.labelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearRedButton;
        private System.Windows.Forms.Button ClearBlueButton;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton BlueRadioButton;
        private System.Windows.Forms.NumericUpDown RedNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown nRectangleNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown BlueNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox ResultsRichTextBox;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RandPointsButton;
    }
}

