// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortAlgorithmService.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebSortAlgorithmVisualizer.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AlgorithmVisualizerLibrary.Contracts;
    using AlgorithmVisualizerLibrary.SortAlgorithms;

    /// <summary>
    /// A sort algorithm service containing available sorting algorithms that can be visualized.
    /// </summary>
    public class SortAlgorithmService
    {
        /// <summary>
        /// A dictionary containing all available sort algorithms.
        /// </summary>
        private readonly Dictionary<SortAlgorithmType, ISortAlgorithmVisualizer> sortAlgorithmMap;

        /// <summary>
        /// Initializes a new instance of the <see cref="SortAlgorithmService"/> class.
        /// </summary>
        public SortAlgorithmService()
        {
            this.sortAlgorithmMap = new Dictionary<SortAlgorithmType, ISortAlgorithmVisualizer>
            {
                { SortAlgorithmType.Bubble, new BubbleSortVisualizer() },
                { SortAlgorithmType.Heap, new HeapSortVisualizer() },
                { SortAlgorithmType.Merge, new MergeSortVisualizer() },
                { SortAlgorithmType.Quick, new QuickSortVisualizer() },
            };
        }

        /// <summary>
        /// Sorts the input values using specified sort algorithm and reports progress.
        /// </summary>
        /// <param name="values">The input values to sort.</param>
        /// <param name="type">The sort algorithm type.</param>
        /// <param name="progress">The sort algorithm progress callback.</param>
        /// <returns>A completed task.</returns>
        public Task Sort(int[] values, SortAlgorithmType type, Action<SortProgress> progress)
        {
            this.sortAlgorithmMap[type].Sort(values, progress);
            return Task.CompletedTask;
        }
    }
}