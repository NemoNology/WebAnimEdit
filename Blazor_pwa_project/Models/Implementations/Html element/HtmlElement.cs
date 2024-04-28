namespace WebAnimEdit.Models.Implementations
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public HashSet<Attribute> Attributes { get; init; }
        public HashSet<HtmlElement> Children { get; init; } = new();

        public HtmlElement(string name, string tag, HashSet<Attribute> attributes)
        {
            Name = name;
            Tag = tag;
            Attributes = attributes;
        }
        public override string ToString() => $"{Name} ({Tag})";
    }
}