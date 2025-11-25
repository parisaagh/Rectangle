# Rectangle Optimization Using Simulated Annealing

This project is a Windows Forms application that lets you place blue and red points on a drawing panel and then uses simulated annealing to create rectangles that group blue points while avoiding red ones. The interface visualizes the points and the resulting rectangles, and displays detailed progress logs while the optimization runs.

---

## Features

- **Interactive point placement**
  - Click to add blue or red points.
  - Generate random sets automatically.

- **Real-time visualization**
  - Points appear as colored circles.
  - Final rectangle layout is drawn after optimization.

- **Simulated annealing engine**
  - Assigns blue points to rectangle groups.
  - Tries to minimize an energy function that:
    - Penalizes red points inside rectangles,
    - Rewards blue points inside rectangles.

- **Progress indicators**
  - Progress bar showing annealing progress.
  - Output log displaying step, temperature, and best energy found.

- **Controls**
  - Start / Stop optimization
  - Reset workspace
  - Clear blue points or red points
  - Set desired number of rectangles
  - Set number of blue/red points for random generation
