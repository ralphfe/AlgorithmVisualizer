
namespace WebAlgorithmVisualizer.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AlgorithmVisualizerLibrary.Contracts;
    using AlgorithmVisualizerLibrary.Models;

    public class SortAlgorithmService
    {
        private readonly Dictionary<SortAlgorithmType, ISortAlgorithmVisualizer> sortAlgorithmMap;

        public SortAlgorithmService()
        {
            this.sortAlgorithmMap = new Dictionary<SortAlgorithmType, ISortAlgorithmVisualizer>
            {
                { SortAlgorithmType.Bubble, new BubbleSortVisualizer() },
                { SortAlgorithmType.Heap, new HeapSortVisualizer() },
                { SortAlgorithmType.Merge, new MergeSortVisualizer() },
                { SortAlgorithmType.Quick, new QuickSortVisualizer() },
            };
        }

        public Task Sort(int[] input, SortAlgorithmType type, Action<SortProgress> progress)
        {
            this.sortAlgorithmMap[type].Sort(input, progress);
            return Task.CompletedTask;
        }
    }
}
