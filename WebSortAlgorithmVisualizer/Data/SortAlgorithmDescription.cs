namespace WebSortAlgorithmVisualizer.Data
{
    public struct SortAlgorithmDescription
    {
        public SortAlgorithmDescription(SortAlgorithmType type, string label)
        {
            this.Type = type;
            this.Label = label;
        }

        public SortAlgorithmType Type { get; }

        public string Label { get; }
    }
}