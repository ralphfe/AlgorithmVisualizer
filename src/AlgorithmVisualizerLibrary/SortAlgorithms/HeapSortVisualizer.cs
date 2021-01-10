// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HeapSortVisualizer.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmVisualizerLibrary.SortAlgorithms
{
    using System;

    using AlgorithmVisualizerLibrary.Contracts;
    using AlgorithmVisualizerLibrary.Internal;

    /// <summary>
    /// A sorting algorithm that makes use of the heap data structure.
    /// The main steps are:
    /// 1. Build a max-heap i.e. when the root node is the largest.
    /// 2. Swap the root node with the element at the last index.
    /// 3. Remove the element and reduce the size of heap by 1.
    /// 4. Create a heap data structure from a binary tree so that we get the largest element at the root again.
    /// 5. Repeat the above steps until all the elements are properly sorted.
    /// </summary>
    public class HeapSortVisualizer : ISortAlgorithmVisualizer
    {
        /// <summary>
        /// Heap sorts input values and optionally report the progress.
        /// </summary>
        /// <param name="values">The values to sort.</param>
        /// <param name="progressCallback">The optional progress callback.</param>
        public void Sort(int[] values, Action<SortProgress> progressCallback = null)
        {
            var heapSize = values.Length;

            this.BuildHeap(values, progressCallback);

            for (var i = heapSize - 1; i >= 1; i--)
            {
                progressCallback?.Invoke(new SortProgress(new[] { 0 }, values));
                SortHelpers.Swap(values, i, 0);
                progressCallback?.Invoke(new SortProgress(new[] { i }, values));

                heapSize--;
                this.Sink(values, heapSize, 0, progressCallback);
            }
        }

        /// <summary>
        /// Converts input values to max-heap.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="progressCallback">The progress callback.</param>
        private void BuildHeap(int[] values, Action<SortProgress> progressCallback)
        {
            var heapSize = values.Length;

            for (var i = (heapSize / 2) - 1; i >= 0; i--)
            {
                this.Sink(values, heapSize, i, progressCallback);
            }
        }

        /// <summary>
        /// Performs a down-heap or sink-down operation for a max-heap.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="heapSize">The heap size.</param>
        /// <param name="i">The index to start at when sinking down.</param>
        /// <param name="progressCallback">The progress callback.</param>
        private void Sink(int[] values, int heapSize, int i, Action<SortProgress> progressCallback)
        {
            int largest = i;

            int left = (2 * i) + 1;
            int right = (2 * i) + 2;

            if (left < heapSize && values[left] > values[largest])
            {
                largest = left;
            }

            if (right < heapSize && values[right] > values[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                progressCallback?.Invoke(new SortProgress(new[] { largest }, values));
                SortHelpers.Swap(values, i, largest);
                progressCallback?.Invoke(new SortProgress(new[] { i }, values));

                this.Sink(values, heapSize, largest, progressCallback);
            }
        }
    }
}