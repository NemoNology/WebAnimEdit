namespace WebAnimEdit.Models.Implementations
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public List<Attribute> Attributes { get; init; }
        public List<HtmlElement> Children { get; init; } = new();

        public HtmlElement(string name, string tag, List<Attribute> attributes)
        {
            Name = name;
            Tag = tag;
            Attributes = attributes;
        }
    }
}