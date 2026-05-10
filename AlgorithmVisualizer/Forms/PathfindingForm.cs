using AlgorithmVisualizer.Algorithms.AlgorithmVisualizer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class Pathfinding_Visualizer : Form
    {
        int gridSize = 20;
        int animationSpeed = 100;
        int[,] grid;
        bool[,] visited;
        int cellWidth;
        int cellHeight;

        Point start = new Point(-1, -1);
        Point end = new Point(-1, -1);

        Queue<Point> queue = new Queue<Point>();
        Dictionary<Point, Point> parent = new Dictionary<Point, Point>();
       public Pathfinding_Visualizer()
        {
            InitializeComponent();
            InitializeGrid();
        }
       private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(gridSize, animationSpeed);

            if (form.ShowDialog() == DialogResult.OK)
            {
           
                gridSize = form.SelectedSize;
                animationSpeed = form.SelectedSpeed;

                start = new Point(-1, -1);
                end = new Point(-1, -1);


                InitializeGrid();
                panelGrid.Invalidate();
                MessageBox.Show($"Grid updated");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (start.X == -1 || end.X == -1)
            {
                MessageBox.Show("Please select start and end points.");
                return;
            }

            queue.Clear();
            parent.Clear();
            visited = new bool[gridSize, gridSize];

            queue.Enqueue(start);
            visited[start.X, start.Y] = true;

            timer1.Interval = Math.Max(1, 101 - animationSpeed);
            timer1.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            start = new Point(-1, -1);
            end = new Point(-1, -1);

            InitializeGrid();
        }


        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            if (grid == null) return;

            cellWidth = panelGrid.Width / gridSize;
            cellHeight = panelGrid.Height / gridSize;

            for (int r = 0; r < gridSize; r++)
            {
                for (int c = 0; c < gridSize; c++)
                {
                    Brush brush = Brushes.White;

                    if (grid[r, c] == 1) brush = Brushes.Black;
                    if (grid[r, c] == 2) brush = Brushes.Green;
                    if (grid[r, c] == 3) brush = Brushes.Red;
                    if (grid[r, c] == 4) brush = Brushes.LightBlue;
                    if (grid[r, c] == 5) brush = Brushes.Yellow;

                    e.Graphics.FillRectangle(
                        brush,
                        c * cellWidth,
                        r * cellHeight,
                        cellWidth - 1,
                        cellHeight - 1
                    );
                }
                
            }

            Pen pen = new Pen(Color.LightGray);

            for (int i = 0; i <= gridSize; i++)
            {
                e.Graphics.DrawLine(pen, i * cellWidth, 0, i * cellWidth, panelGrid.Height);
            }

            for (int i = 0; i <= gridSize; i++)
            {
                e.Graphics.DrawLine(pen, 0, i * cellHeight, panelGrid.Width, i * cellHeight);
            }
        }

        private void panelGrid_MouseClick(object sender, MouseEventArgs e)
        {
            cellWidth = panelGrid.Width / gridSize;
            cellHeight = panelGrid.Height / gridSize;

            int c = e.X / cellWidth;
            int r = e.Y / cellHeight;

            if (r < 0 || r >= gridSize || c < 0 || c >= gridSize)
                return;

            if (start.X == -1)
            {
                start = new Point(r, c);
                grid[r, c] = 2;
            }
            else if (end.X == -1)
            {
                end = new Point(r, c);
                grid[r, c] = 3;
            }
            else
            {
                grid[r, c] = 1;
            }

            panelGrid.Invalidate();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (queue.Count == 0)
            {
                timer1.Stop();
                MessageBox.Show("No path found");
                return;
            }

            Point current = queue.Dequeue();

            if (current == end)
            {
                timer1.Stop();
                DrawPath();
                return;
            }

            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };

            for (int i = 0; i < 4; i++)
            {
                int nr = current.X + dr[i];
                int nc = current.Y + dc[i];

                if (nr >= 0 && nr < gridSize && nc >= 0 && nc < gridSize)
                {
                    if (!visited[nr, nc] && grid[nr, nc] != 1)
                    {
                        visited[nr, nc] = true;
                        queue.Enqueue(new Point(nr, nc));
                        parent[new Point(nr, nc)] = current;

                        if (grid[nr, nc] != 3)
                            grid[nr, nc] = 4; 
                    }
                }
            }

            panelGrid.Invalidate();
        }

        void InitializeGrid()
        {
            grid = new int[gridSize, gridSize];
            visited = new bool[gridSize, gridSize];
            queue.Clear();
            parent.Clear();
            panelGrid.Invalidate();
        }

        void DrawPath()
        {
            Point current = end;

            while (current != start)
            {
                if (grid[current.X, current.Y] != 3)
                    grid[current.X, current.Y] = 5;

                current = parent[current];
            }

            panelGrid.Invalidate();
        }

       private void Pathfinding_Visualizer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
