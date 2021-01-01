

namespace AlgorithmVisualzierLibrary.Contracts
{
    using System;
    using AlgorithmVisualzierLibrary.Models;

    public interface ISortAlgorithmVisualizer
    {
        void Sort(int[] values, Action<SortProgress> progressCallback = null);
    }
}
