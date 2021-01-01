

namespace AlgorithmVisualizerLibrary.Models
{
    using System;
    using AlgorithmVisualzierLibrary.Contracts;
    using AlgorithmVisualzierLibrary.Models;

    public class QuickSortVisualizer : ISortAlgorithmVisualizer
    {
        public void Sort(int[] values, Action<SortProgress> progressCallback = null)
        {
            this.QuickSort(values, 0, values.Length - 1, progressCallback);
        }
        
        private void QuickSort(int[] arr, int start, int end, Action<SortProgress> progressCallback = null)
        {
            int i;
            if (start < end)
            {
                i = this.Partition(arr, start, end, progressCallback);

                this.QuickSort(arr, start, i - 1, progressCallback);
                this.QuickSort(arr, i + 1, end, progressCallback);
            }
        }

        private int Partition(int[] arr, int start, int end, Action<SortProgress> progressCallback = null)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    progressCallback?.Invoke(new SortProgress(i, arr));

                    arr[j] = temp;
                    progressCallback?.Invoke(new SortProgress(j, arr));
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            progressCallback?.Invoke(new SortProgress(i + 1, arr));

            arr[end] = temp;
            progressCallback?.Invoke(new SortProgress(end, arr));
            return i + 1;
        }
    }
}
