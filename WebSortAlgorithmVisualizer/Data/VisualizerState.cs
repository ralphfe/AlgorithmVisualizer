// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VisualizerState.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace WebSortAlgorithmVisualizer.Data
{
    /// <summary>
    /// An enumeration describing algorithm visualizer state.
    /// </summary>
    public enum VisualizerState
    {
        /// <summary>
        /// Idle state.
        /// </summary>
        Idle,

        /// <summary>
        /// Sorting visualization is in progress.
        /// </summary>
        Sorting,

        /// <summary>
        /// Sorting visualization is cancelled.
        /// </summary>
        Cancelled,

        /// <summary>
        /// Sorting visualization completed successfully.
        /// </summary>
        Completed
    }
}