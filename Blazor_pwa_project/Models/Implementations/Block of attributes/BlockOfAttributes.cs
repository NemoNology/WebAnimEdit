using WebAnimEdit.Models.Enums;

namespace WebAnimEdit.Models.Implementations
{
    public class BlockOfAttributes
    {
        public BlockOfAttributesType Type { get; init; }
        public HashSet<Attribute> Attributes { get; init; }

        public BlockOfAttributes(HashSet<Attribute> attributes)
        {
            Type = BlockOfAttributesType.Custom;
            Attributes = attributes;
        }

        public BlockOfAttributes(BlockOfAttributesType type)
        {
            Type = type;
            Attributes = this.GetAttributes();
        }

        public BlockOfAttributes()
        {
            Type = BlockOfAttributesType.Custom;
            Attributes = new(2);
        }
    }
}