namespace AlgorithmVisualzierLibrary.Models
{
    readonly public struct SortProgress
    {
        public SortProgress(int currentIndex, int[] currentValues)
        {
            this.CurrentIndex = currentIndex;
            this.CurrentValues = (int[])currentValues.Clone();
        }

        public int CurrentIndex { get; }

        public int[] CurrentValues { get; }
    }
}