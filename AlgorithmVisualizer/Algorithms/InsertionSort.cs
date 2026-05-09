using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmVisualizer.Algorithms
{
    public class InsertionSort
    {
        public int Comparisons { get; private set; }

        public IEnumerable<int> Sort(int[] array)
        {
            Comparisons = 0;
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    Comparisons++;
                    array[j + 1] = array[j];
                    j--;
                    // Yield return to update the UI after each shift
                    yield return j + 1;
                }
                array[j + 1] = key;
                yield return i;
            }
        }
    }
}
