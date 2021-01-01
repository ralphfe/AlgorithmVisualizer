
namespace AlgorithmVisualizerLibrary.Models
{
    using System;
    using AlgorithmVisualzierLibrary.Contracts;
    using AlgorithmVisualzierLibrary.Models;

    public class HeapSortVisualizer : ISortAlgorithmVisualizer
    {
        private int heapSize;

        public void Sort(int[] values, Action<SortProgress> progressCallback = null)
        {
            this.BuildHeap(values);

            for (int i = values.Length - 1; i >= 0; i--)
            {
                this.Swap(values, 0, i, progressCallback);
                heapSize--;
                this.Heapify(values, 0, progressCallback);
            }
        }

        private void BuildHeap(int[] arr, Action<SortProgress> progressCallback = null)
        {
            heapSize = arr.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--)
            {
                this.Heapify(arr, i, progressCallback);
            }
        }

        //function to swap elements
        private void Swap(int[] arr, int x, int y, Action<SortProgress> progressCallback = null)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            progressCallback?.Invoke(new SortProgress(x, arr));

            arr[y] = temp;
            progressCallback?.Invoke(new SortProgress(y, arr));
        }

        private void Heapify(int[] arr, int index, Action<SortProgress> progressCallback = null)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest = index;
            if (left <= heapSize && arr[left] > arr[index])
            {
                largest = left;
            }

            if (right <= heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                this.Swap(arr, index, largest, progressCallback);
                this.Heapify(arr, largest, progressCallback);
            }
        }
    }
}
