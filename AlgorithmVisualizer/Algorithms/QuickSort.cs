
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmVisualizer.Algorithms
{
    public class QuickSort
    {
        public int Comparisons { get; private set; }

        public IEnumerable<int> Sort(int[] array)
        {
            Comparisons = 0;
            Stack<(int, int)> stack = new Stack<(int, int)>();
            stack.Push((0, array.Length - 1));

            while (stack.Count > 0)
            {
                var (low, high) = stack.Pop();
                if (low < high)
                {
                    int pivotIndex = low;
                    int pivotValue = array[high];

                    for (int i = low; i < high; i++)
                    {
                        Comparisons++;
                        if (array[i] < pivotValue)
                        {
                            Swap(array, i, pivotIndex);
                            pivotIndex++;
                            yield return i; // Pause for animation
                        }
                    }
                    Swap(array, pivotIndex, high);
                    yield return pivotIndex;

                    stack.Push((pivotIndex + 1, high));
                    stack.Push((low, pivotIndex - 1));
                }
            }
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
