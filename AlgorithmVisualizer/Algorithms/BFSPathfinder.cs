using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmVisualizer.Algorithms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    namespace AlgorithmVisualizer
    {
        public class BFSPathfinder
        {
            private int[,] grid;
            private int rows, cols;

            private Point start;
            private Point end;

            private bool[,] visited;
            private Point[,] parent;

            public List<Point> VisitedOrder { get; private set; }
            public List<Point> FinalPath { get; private set; }

            public BFSPathfinder(int[,] grid, Point start, Point end)
            {
                this.grid = grid;
                this.rows = grid.GetLength(0);
                this.cols = grid.GetLength(1);
                this.start = start;
                this.end = end;

                visited = new bool[rows, cols];
                parent = new Point[rows, cols];

                VisitedOrder = new List<Point>();
                FinalPath = new List<Point>();
            }

            public void RunBFS()
            {
                Queue<Point> queue = new Queue<Point>();

                queue.Enqueue(start);
                visited[start.X, start.Y] = true;

                int[] dx = { -1, 1, 0, 0 };
                int[] dy = { 0, 0, -1, 1 };

                bool found = false;

                while (queue.Count > 0)
                {
                    Point current = queue.Dequeue();
                    VisitedOrder.Add(current);

                    if (current == end)
                    {
                        found = true;
                        break;
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        int nx = current.X + dx[i];
                        int ny = current.Y + dy[i];

                        if (IsValid(nx, ny))
                        {
                            visited[nx, ny] = true;
                            queue.Enqueue(new Point(nx, ny));
                            parent[nx, ny] = current;
                        }
                    }
                }

                if (found)
                {
                    BuildPath();
                }
            }

            private bool IsValid(int x, int y)
            {
                return x >= 0 && y >= 0 &&
                       x < rows && y < cols &&
                       !visited[x, y] &&
                       grid[x, y] != 1; // 1 = wall
            }

            private void BuildPath()
            {
                Point current = end;

                while (current != start)
                {
                    FinalPath.Add(current);
                    current = parent[current.X, current.Y];
                }

                FinalPath.Add(start);
                FinalPath.Reverse();
            }
        }
    }
}
