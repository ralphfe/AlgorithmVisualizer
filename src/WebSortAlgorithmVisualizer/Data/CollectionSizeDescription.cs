// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollectionSizeDescription.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebSortAlgorithmVisualizer.Data
{
    /// <summary>
    /// Describes the selectable collection size.
    /// </summary>
    public struct CollectionSizeDescription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionSizeDescription"/> struct.
        /// </summary>
        /// <param name="size">The size of collection.</param>
        /// <param name="label">The label, e.g. "large".</param>
        /// <param name="description">The description, e.g. "50 entries".</param>
        public CollectionSizeDescription(int size, string label, string description)
        {
            this.Size = size;
            this.Label = label;
            this.Description = description;
        }

        /// <summary>
        /// Gets the size of collection associated with the selection.
        /// </summary>
        public int Size { get; }

        /// <summary>
        /// Gets the label, e.g. "large".
        /// </summary>
        public string Label { get; }

        /// <summary>
        /// Gets the description, e.g. "50 entries".
        /// </summary>
        public string Description { get; }
    }
}