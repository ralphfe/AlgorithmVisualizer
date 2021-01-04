
namespace AlgorithmVisualizerTests.SortAlgorithmTests
{
    using AlgorithmVisualizerLibrary.SortAlgorithms;

    using NUnit.Framework;

    [TestFixture()]
    public class BubbleSortVisualizerTests : AlgorithmProgressReporterTestBase
    {
        [SetUp]
        public void Setup()
        {
            this.sortVisualizer = new BubbleSortVisualizer();
        }
    }
}