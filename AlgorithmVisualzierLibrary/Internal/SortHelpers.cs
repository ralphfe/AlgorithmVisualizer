// ----------------------------------------------------------------------
// <copyright file="SortHelpers.cs" company="none">
//   Copyright (c) 2021, MIT.
// </copyright>
// ----------------------------------------------------------------------

namespace AlgorithmVisualizerLibrary.Internal
{
    using System;

    using AlgorithmVisualizerLibrary.SortAlgorithms;

    internal static class SortHelpers
    {
        public static void Swap(int[] values, int x, int y, Action<SortProgress> progressCallback = null)
        {
            var tmpVal = values[x];
            values[x] = values[y];
            progressCallback?.Invoke(new SortProgress(x, values));

            values[y] = tmpVal;
            progressCallback?.Invoke(new SortProgress(y, values));
        }
    }
}