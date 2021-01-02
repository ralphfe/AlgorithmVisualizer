// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISortAlgorithmVisualizer.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmVisualizerLibrary.Contracts
{
    using System;

    using AlgorithmVisualizerLibrary.SortAlgorithms;

    /// <summary>
    /// A contract defining sort algorithm visualizer.
    /// </summary>
    public interface ISortAlgorithmVisualizer
    {
        /// <summary>
        /// Sorts input values and optionally report the progress.
        /// </summary>
        /// <param name="values">The values to sort.</param>
        /// <param name="progressCallback">The optional progress callback.</param>
        void Sort(int[] values, Action<SortProgress> progressCallback = null);
    }
}
