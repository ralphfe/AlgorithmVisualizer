// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SortAlgorithmDescription.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebSortAlgorithmVisualizer.Data
{
    /// <summary>
    /// Describes the selectable sort algorithm.
    /// </summary>
    public struct SortAlgorithmDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortAlgorithmDescription"/> struct.
        /// </summary>
        /// <param name="type">The sort algorithm type.</param>
        /// <param name="label">The label, e.g. "merge sort"</param>
        public SortAlgorithmDescription(SortAlgorithmType type, string label)
        {
            this.Type = type;
            this.Label = label;
        }

        /// <summary>
        /// Gets the sort algorithm type associated with the selection.
        /// </summary>
        public SortAlgorithmType Type { get; }

        /// <summary>
        /// Gets the label, e.g. "merge sort.
        /// </summary>
        public string Label { get; }
    }
}