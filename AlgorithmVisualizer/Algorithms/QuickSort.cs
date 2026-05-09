using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmVisualizer.Algorithms
{
    public class QuickSort
    {
        private int[] data;
        private Stack<(int low, int high)> stack;
        private int i, j, pivot, low, high;
        private bool partitioning;
        private bool isSorting;

        public void Initialize(int[] array, int start, int end)
        {
            this.data = array;
            this.stack = new Stack<(int, int)>();
            this.stack.Push((start, end));
            this.isSorting = true;
            this.partitioning = false;
        }

        public bool Step(Action<int, int, bool> updateUI)
        {
            if (!isSorting) return true;

            if (!partitioning)
            {
                if (stack.Count == 0) return true;

                var range = stack.Pop();
                low = range.low;
                high = range.high;

                if (low >= high) return false;

                pivot = data[high];
                i = low - 1;
                j = low;
                partitioning = true;
            }

            if (partitioning)
            {
                if (j <= high - 1)
                {
                    if (data[j] < pivot)
                    {
                        i++;
                        Swap(i, j);
                        updateUI(i, j, true);
                    }
                    else
                    {
                        updateUI(i, j, false);
                    }
                    j++;
                }
                else
                {
                    Swap(i + 1, high);
                    updateUI(i + 1, high, true);

                    int pIdx = i + 1;
                    stack.Push((pIdx + 1, high));
                    stack.Push((low, pIdx - 1));
                    partitioning = false;
                }
            }
            return false;
        }

        private void Swap(int a, int b)
        {
            int temp = data[a];
            data[a] = data[b];
            data[b] = temp;
        }
    }

}
