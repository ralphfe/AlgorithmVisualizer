


namespace AlgorithmVisualizerLibrary.Models
{
    using System;
    using AlgorithmVisualzierLibrary.Contracts;
    using AlgorithmVisualzierLibrary.Models;

    public class MergeSortVisualizer : ISortAlgorithmVisualizer
    {
        public void Sort(int[] values, Action<SortProgress> progressCallback = null)
        {
            this.MergeSort(values, 0, values.Length - 1, progressCallback);
        }

        private void MergeSort(int[] input, int startIndex, int endIndex, Action<SortProgress> progressCallback = null)
        {
            int mid;

            if (endIndex > startIndex)
            {
                mid = (endIndex + startIndex) / 2;
                this.MergeSort(input, startIndex, mid, progressCallback);
                this.MergeSort(input, (mid + 1), endIndex, progressCallback);
                this.Merge(input, startIndex, (mid + 1), endIndex, progressCallback);
            }
        }

        private void Merge(int[] input, int left, int mid, int right, Action<SortProgress> progressCallback = null)
        {
            // Merge takes O(n) time
            int[] temp = new int[input.Length];
            int i;
            var leftEnd = mid - 1;
            var tmpPos = left;
            var lengthOfInput = right - left + 1;

            // Selecting smaller element from left sorted array or right sorted array and placing them in temp array
            while ((left <= leftEnd) && (mid <= right))
            {
                if (input[left] <= input[mid])
                {
                    temp[tmpPos++] = input[left++];
                }
                else
                {
                    temp[tmpPos++] = input[mid++];
                }
            }

            // Placing remaining element in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[tmpPos++] = input[left++];
            }

            // Placing remaining element in temp from right sorted array
            while (mid <= right)
            {
                temp[tmpPos++] = input[mid++];
            }

            // Placing temp array to input
            for (i = 0; i < lengthOfInput; i++)
            {
                input[right] = temp[right];
                progressCallback?.Invoke(new SortProgress(right, input));

                right--;
            }
        }
    }
}
