

namespace AlgorithmVisualizerLibrary.Models
{
    using System;
    using AlgorithmVisualzierLibrary.Contracts;
    using AlgorithmVisualzierLibrary.Models;

    public class BubbleSortVisualizer : ISortAlgorithmVisualizer
    {
        public void Sort(int[] values, Action<SortProgress> progressCallback = null)
        {
            int temp;

            for (int write = 0; write < values.Length; write++)
            {
                for (int sort = 0; sort < values.Length - 1; sort++)
                {
                    if (values[sort] > values[sort + 1])
                    {
                        temp = values[sort + 1];
                        values[sort + 1] = values[sort];
                        progressCallback?.Invoke(new SortProgress(sort + 1, values));
                        
                        values[sort] = temp;
                        progressCallback?.Invoke(new SortProgress(sort, values));
                    }
                }
            }
        }
    }
}
