namespace WebAlgorithmVisualizer.Data
{
    public struct CollectionSizeDescription
    {
        public CollectionSizeDescription(int size, string label, string description)
        {
            this.Size = size;
            this.Label = label;
            this.Description = description;
        }

        public int Size { get; }
        public string Label { get; }
        public string Description { get; }
    }
}