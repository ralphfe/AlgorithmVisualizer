

namespace AlgorithmVisualizerTests.SortAlgorithmTests
{
    using AlgorithmVisualizerLibrary.SortAlgorithms;

    using NUnit.Framework;

    [TestFixture()]
    public class MergeSortVisualizerTests : AlgorithmProgressReporterTestBase
    {
        [SetUp]
        public void Setup()
        {
            this.sortVisualizer = new MergeSortVisualizer();
        }
    }
}