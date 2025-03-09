using WebAnimEdit.Models.Implementations;

namespace WebAnimEdit.Models.Enums
{
    public static class BlocksOfAttributes
    {
        public static BlockOfAttributes Text => new(BlockOfAttributesType.Text);
        public static BlockOfAttributes Shape => new(BlockOfAttributesType.Shape);
        public static BlockOfAttributes Transform => new(BlockOfAttributesType.Transform);
        public static BlockOfAttributes Style => new(BlockOfAttributesType.Style);
        public static BlockOfAttributes Event => new(BlockOfAttributesType.Event);
        public static BlockOfAttributes StyleSheet => new(BlockOfAttributesType.StyleSheet);
        public static BlockOfAttributes Script => new(BlockOfAttributesType.Script);
        public static BlockOfAttributes Input => new(BlockOfAttributesType.Input);
        public static BlockOfAttributes Image => new(BlockOfAttributesType.Image);
        public static BlockOfAttributes Custom = new();
        //  HeadMeta => new(
        //     "Голова документа. Мета",
        //     new()
        //     {
        //         new("Мета. Кодировка", "charset", "utf8"),
        //         new("Мета. Viewport", "name", "viewport"),
        //     }
        // );

    }
}