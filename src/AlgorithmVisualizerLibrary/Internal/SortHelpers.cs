// ----------------------------------------------------------------------
// <copyright file="SortHelpers.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// ----------------------------------------------------------------------

namespace AlgorithmVisualizerLibrary.Internal
{
    /// <summary>
    /// A static helper class containing methods used by sorting algorithm visualizers.
    /// </summary>
    internal static class SortHelpers
    {
        /// <summary>
        /// Swaps two elements at specified indexes in the values collection.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="x">The first value index.</param>
        /// <param name="y">The second value index.</param>
        public static void Swap(int[] values, int x, int y)
        {
            var tmpVal = values[x];
            values[x] = values[y];
            values[y] = tmpVal;
        }
    }
}