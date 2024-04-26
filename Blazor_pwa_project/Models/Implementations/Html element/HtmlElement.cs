namespace WebAnimEdit.Models.Implementations
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public BlockOfProperties[] BlocksOfProperties { get; init; }
        public string Text { get; set; } = "";
        public List<HtmlElement> Children { get; init; } = new();

        public HtmlElement(string name, string tag, BlockOfProperties[] blocksOfProperties)
        {
            Name = name;
            Tag = tag;
            BlocksOfProperties = blocksOfProperties;
        }
    }
}