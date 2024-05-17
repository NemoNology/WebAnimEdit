using WebAnimEdit.Models.Enums;

namespace WebAnimEdit.Models.Implementations
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public HashSet<BlockOfAttributes> BlocksOfAttributes { get; init; }
        public HashSet<HtmlElement> Children { get; init; }

        public HtmlElement(string name, string tag, HashSet<BlockOfAttributes> blocksOfAttributes)
        {
            Name = name;
            Tag = tag;
            BlocksOfAttributes = blocksOfAttributes;
            BlocksOfAttributes.Add(WebAnimEdit.Models.Enums.BlocksOfAttributes.Custom);
            Children = new();
        }

        public override string ToString() => $"{Name} ({Tag})";

        public void RemoveAttribute(Attribute attr)
        {
            foreach (var block in BlocksOfAttributes)
            {
                if (block.Attributes.Contains(attr))
                {
                    block.Attributes.Remove(attr);
                    return;
                }
            }
        }
    }
}