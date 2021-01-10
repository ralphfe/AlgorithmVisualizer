// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuickSortVisualizer.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmVisualizerLibrary.SortAlgorithms
{
    using System;
    using AlgorithmVisualizerLibrary.Contracts;
    using AlgorithmVisualizerLibrary.Internal;

    /// <summary>
    /// A divide and conquer algorithm that picks an element as pivot and partitions the given input around it.
    /// </summary>
    public class QuickSortVisualizer : ISortAlgorithmVisualizer
    {
        /// <summary>
        /// Quick sorts input values and optionally report the progress.
        /// </summary>
        /// <param name="values">The values to sort.</param>
        /// <param name="progressCallback">The optional progress callback.</param>
        public void Sort(int[] values, Action<SortProgress> progressCallback = null)
        {
            this.QuickSort(values, 0, values.Length - 1, progressCallback);
        }

        /// <summary>
        /// Takes last element as pivot, places the pivot element at its correct position in sorted array,
        /// and places all smaller (smaller than pivot) to left of pivot and all greater elements to right of pivot.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="start">The start index.</param>
        /// <param name="end">The end index.</param>
        /// <param name="progressCallback">The progress callback.</param>
        /// <returns>A partitioning index.</returns>
        private int Partition(int[] values, int start, int end, Action<SortProgress> progressCallback)
        {
            var pivot = values[end];
            var i = start - 1;

            for (var j = start; j <= end - 1; j++)
            {
                if (values[j] <= pivot)
                {
                    i++;
                    SortHelpers.Swap(values, i, j);
                    progressCallback?.Invoke(new SortProgress(new[] { i, j, start, end }, values));
                }
            }

            SortHelpers.Swap(values, i + 1, end);
            progressCallback?.Invoke(new SortProgress(new[] { i + 1, start, end }, values));
            return i + 1;
        }

        /// <summary>
        /// Recursively calls the quick sort.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="start">The start index.</param>
        /// <param name="end">The end index.</param>
        /// <param name="progressCallback">The progress callback.</param>
        private void QuickSort(int[] values, int start, int end, Action<SortProgress> progressCallback)
        {
            if (start < end)
            {
                int pi = this.Partition(values, start, end, progressCallback);

                this.QuickSort(values, start, pi - 1, progressCallback);
                this.QuickSort(values, pi + 1, end, progressCallback);
            }
        }
    }
}