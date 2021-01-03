
namespace AlgorithmVisualizerTests.SortAlgorithmTests
{
    using System;

    using AlgorithmVisualizerLibrary.Contracts;

    using NUnit.Framework;

    [TestFixture()]
    public abstract class AlgorithmProgressReporterTestBase
    {
        protected ISortAlgorithmVisualizer sortVisualizer;
        private int[] randomTestArrayInit;
        private int[] randomTestArrayExpected;

        public AlgorithmProgressReporterTestBase()
        {
            var randNum = new Random();

            this.randomTestArrayInit = new int[1000];
            for (int i = 0; i < this.randomTestArrayInit.Length; i++)
            {
                this.randomTestArrayInit[i] = randNum.Next(int.MinValue, int.MaxValue);
            }

            // Use default array sort as reference
            this.randomTestArrayExpected = (int[])this.randomTestArrayInit.Clone();
            Array.Sort(this.randomTestArrayExpected);
        }

        [Test]
        public void SortTestCase1()
        {
            var init = new int[] { 1, 2, 3, 4, 5, 6 };
            var sort = new int[] { 1, 2, 3, 4, 5, 6 };

            this.sortVisualizer.Sort(sort);

            Assert.AreEqual(init, sort, "Arrays are not equal");
        }

        [Test]
        public void SortTestCase2()
        {
            var init = new int[] { 1, 2, 4, 5, 2, 6 };
            var expected = new int[] { 1, 2, 2, 4, 5, 6 };
            var sort = (int[])init.Clone();

            this.sortVisualizer.Sort(sort);

            Assert.AreEqual(expected, sort, "Arrays are not equal");
        }

        [Test]
        public void SortTestCase3()
        {
            var init = new int[] { 3, 2, 1, 5, 6, 4 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };
            var sort = (int[])init.Clone();

            this.sortVisualizer.Sort(sort);

            Assert.AreEqual(expected, sort, "Arrays are not equal");
        }

        [Test]
        public void SortTestCaseRandom1000()
        {
            var init = this.randomTestArrayInit;
            var expected = this.randomTestArrayExpected;
            var sort = init;

            TestContext.WriteLine($"Random input: [{string.Join(", ", init)}]");
            TestContext.WriteLine($"Expected result: [{string.Join(", ", expected)}]");

            this.sortVisualizer.Sort(sort);

            Assert.AreEqual(expected, sort, "Arrays are not equal");

            TestContext.WriteLine($"Actual result: [{string.Join(", ", sort)}]");
        }
    }
}
