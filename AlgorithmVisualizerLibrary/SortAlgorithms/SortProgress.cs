// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortProgress.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AlgorithmVisualizerLibrary.SortAlgorithms
{
    /// <summary>
    /// The sorting algorithm progress.
    /// </summary>
    public struct SortProgress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortProgress"/> struct.
        /// </summary>
        /// <param name="highlightIndex">The index to highlight.</param>
        /// <param name="values">The values.</param>
        public SortProgress(int highlightIndex, int[] values)
        {
            this.HighlightIndex = highlightIndex;
            this.Values = (int[])values.Clone();
        }

        /// <summary>
        /// Gets the index to highlight.
        /// </summary>
        public int HighlightIndex { get; }

        /// <summary>
        /// Gets the current values.
        /// </summary>
        public int[] Values { get; }
    }
}