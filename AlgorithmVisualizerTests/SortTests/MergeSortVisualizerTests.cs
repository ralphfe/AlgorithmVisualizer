

namespace AlgorithmVisualizerLibrary.Models.Tests
{
    using NUnit.Framework;
    using AlgorithmVisualizerLibrary.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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