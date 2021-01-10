// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MergeSortVisualizer.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmVisualizerLibrary.SortAlgorithms
{
    using System;
    using AlgorithmVisualizerLibrary.Contracts;

    /// <summary>
    /// A divide and Conquer algorithm that divides the input array into two halves,
    /// calls itself for the two halves, and then merges the two sorted halves.
    /// </summary>
    public class MergeSortVisualizer : ISortAlgorithmVisualizer
    {
        /// <summary>
        /// Merge sorts input values and optionally report the progress.
        /// </summary>
        /// <param name="values">The values to sort.</param>
        /// <param name="progressCallback">The optional progress callback.</param>
        public void Sort(int[] values, Action<SortProgress> progressCallback = null)
        {
            this.MergeSort(values, 0, values.Length - 1, progressCallback);
        }

        /// <summary>
        /// Merges two sorted halves.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="left">The left half index, i.e. from values range [left..mid].</param>
        /// <param name="mid">The mid point between two sorted halves.</param>
        /// <param name="right">The right half index, i.e. from values range [mid+1..right].</param>
        /// <param name="progressCallback">The progress callback.</param>
        private void Merge(int[] values, int left, int mid, int right, Action<SortProgress> progressCallback)
        {
            var temp = new int[values.Length];
            int i;
            var leftEnd = mid - 1;
            var initLeft = left;
            var initRight = right;
            var tmpPos = left;
            var lengthOfInput = right - left + 1;

            // Selecting smaller element from left sorted array or right sorted array and placing them in temp array
            while (left <= leftEnd && mid <= right)
            {
                if (values[left] <= values[mid])
                {
                    temp[tmpPos++] = values[left++];
                }
                else
                {
                    temp[tmpPos++] = values[mid++];
                }
            }

            // Placing remaining element in temp from left sorted array
            while (left <= leftEnd)
            {
                temp[tmpPos++] = values[left++];
            }

            // Placing remaining element in temp from right sorted array
            while (mid <= right)
            {
                temp[tmpPos++] = values[mid++];
            }

            // Placing temp array to input
            for (i = 0; i < lengthOfInput; i++)
            {
                values[right] = temp[right];
                progressCallback?.Invoke(new SortProgress(new[] { initLeft, leftEnd, initRight, right }, values));

                right--;
            }
        }

        /// <summary>
        /// Recursively merge sorts the input values.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="start">The start index.</param>
        /// <param name="end">The end index.</param>
        /// <param name="progressCallback">The progress callback.</param>
        private void MergeSort(int[] values, int start, int end, Action<SortProgress> progressCallback)
        {
            int mid;

            if (end > start)
            {
                // Find the middle point to divide the array into two halves
                mid = (end + start) / 2;

                // Call merge sort for first half
                this.MergeSort(values, start, mid, progressCallback);

                // Call merge sort for second half
                this.MergeSort(values, mid + 1, end, progressCallback);

                // Merge the two halves sorted
                this.Merge(values, start, mid + 1, end, progressCallback);
            }
        }
    }
}