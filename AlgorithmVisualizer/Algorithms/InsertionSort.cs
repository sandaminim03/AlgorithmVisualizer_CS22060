using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmVisualizer.Algorithms
{
    public class InsertionSort
    {
        private int[] data;
        private int i;
        private int j;
        private bool isSorting;

        public void Initialize(int[] array)
        {
            this.data = array;
            this.i = 1;
            this.j = 0;
            this.isSorting = true;
        }

        public bool Step(Action<int, int, bool> updateUI)
        {
            if (!isSorting || i >= data.Length)
            {
                isSorting = false;
                return true; // Sorting is finished
            }

            if (j >= 0 && data[j] > data[j + 1])
            {
                // Perform the swap
                int temp = data[j];
                data[j] = data[j + 1];
                data[j + 1] = temp;

                updateUI(j, j + 1, true);
                j--;
                return false; // Step completed, continue sorting
            }
            else
            {
                i++;
                j = i - 1;
                return false;
            }
        }
    }

}
