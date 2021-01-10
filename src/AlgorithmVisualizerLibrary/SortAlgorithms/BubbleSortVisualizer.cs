// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BubbleSortVisualizer.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmVisualizerLibrary.SortAlgorithms
{
    using System;

    using AlgorithmVisualizerLibrary.Contracts;
    using AlgorithmVisualizerLibrary.Internal;

    /// <summary>
    /// A comparison-based sorting algorithm in which each pair of adjacent elements
    /// is compared and the elements are swapped if they are not in order.
    /// </summary>
    public class BubbleSortVisualizer : ISortAlgorithmVisualizer
    {
        /// <summary>
        /// Bubble sorts input values and optionally report the progress.
        /// </summary>
        /// <param name="values">The values to sort.</param>
        /// <param name="progressCallback">The optional progress callback.</param>
        public void Sort(int[] values, Action<SortProgress> progressCallback = null)
        {
            for (var write = 0; write < values.Length; write++)
            {
                for (var sort = 0; sort < values.Length - 1; sort++)
                {
                    if (values[sort] > values[sort + 1])
                    {
                        SortHelpers.Swap(values, sort + 1, sort);
                        progressCallback?.Invoke(new SortProgress(new[] { sort + 1 }, values));
                    }
                }
            }
        }
    }
}