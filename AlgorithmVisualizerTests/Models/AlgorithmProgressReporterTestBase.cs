
namespace AlgorithmVisualizerLibrary.Models.Tests
{
    using System;
    using NUnit.Framework;
    using AlgorithmVisualizerLibrary.Contracts;

    [TestFixture()]
    public abstract class AlgorithmProgressReporterTestBase
    {
        protected ISortAlgorithmVisualizer sortVisualizer;
        private int[] randomTestArrayInit;
        private int[] randomTestArrayExpected;

        public AlgorithmProgressReporterTestBase()
        {
            var randNum = new Random();

            randomTestArrayInit = new int[1000];
            for (int i = 0; i < randomTestArrayInit.Length; i++)
            {
                randomTestArrayInit[i] = randNum.Next(int.MinValue, int.MaxValue);
            }

            // Use default array sort as reference
            randomTestArrayExpected = (int[])randomTestArrayInit.Clone();
            Array.Sort(randomTestArrayExpected);
        }

        [Test]
        public void SortTestCase1()
        {
            var init = new int[] { 1, 2, 3, 4, 5, 6 };
            var sort = new int[] { 1, 2, 3, 4, 5, 6 };

            sortVisualizer.Sort(sort);

            Assert.AreEqual(init, sort, "Arrays are not equal");
        }

        [Test]
        public void SortTestCase2()
        {
            var init = new int[] { 1, 2, 4, 5, 2, 6 };
            var expected = new int[] { 1, 2, 2, 4, 5, 6 };
            var sort = (int[])init.Clone();

            sortVisualizer.Sort(sort);

            Assert.AreEqual(expected, sort, "Arrays are not equal");
        }

        [Test]
        public void SortTestCase3()
        {
            var init = new int[] { 3, 2, 1, 5, 6, 4 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };
            var sort = (int[])init.Clone();

            sortVisualizer.Sort(sort);

            Assert.AreEqual(expected, sort, "Arrays are not equal");
        }

        [Test]
        public void SortTestCaseRandom1000()
        {
            var init = randomTestArrayInit;
            var expected = randomTestArrayExpected;
            var sort = init;

            TestContext.WriteLine($"Random input: [{string.Join(", ", init)}]");
            TestContext.WriteLine($"Expected result: [{string.Join(", ", expected)}]");

            sortVisualizer.Sort(sort);

            Assert.AreEqual(expected, sort, "Arrays are not equal");

            TestContext.WriteLine($"Actual result: [{string.Join(", ", sort)}]");
        }
    }
}
