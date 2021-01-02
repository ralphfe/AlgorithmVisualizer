

namespace AlgorithmVisualizerLibrary.Contracts
{
    using System;
    using AlgorithmVisualizerLibrary.Models;

    public interface ISortAlgorithmVisualizer
    {
        void Sort(int[] values, Action<SortProgress> progressCallback = null);
    }
}
