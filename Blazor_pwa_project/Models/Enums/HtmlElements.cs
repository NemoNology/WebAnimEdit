using WebAnimEdit.Models.Implementations;
using Attribute = WebAnimEdit.Models.Implementations.Attribute;

namespace WebAnimEdit.Models.Enums
{
    public static class HtmlElements
    {
        public static HashSet<BlockOfAttributes> DivisionBlocksOfAttributes =>
            new()
            {
                BlocksOfAttributes.Text,
                BlocksOfAttributes.Shape,
                BlocksOfAttributes.Transform,
                BlocksOfAttributes.Style,
                BlocksOfAttributes.Event,
            };

        public static HtmlElement Division => new(
            "Разделитель",
            "div",
            DivisionBlocksOfAttributes);
        public static HtmlElement Image => new(
            "Изображение",
            "div",
            new()
            {
                BlocksOfAttributes.Image,
                BlocksOfAttributes.Shape,
                BlocksOfAttributes.Transform,
                BlocksOfAttributes.Style,
                BlocksOfAttributes.Event,
            });
        public static HtmlElement Button => new(
            "Кнопка",
            "button",
            DivisionBlocksOfAttributes);
        public static HtmlElement Document => new(
            "HTML-документ",
            "html",
            DivisionBlocksOfAttributes)
        {
            Children = new()
            {
                DocumentHead,
                new("Тело документа", "body", DivisionBlocksOfAttributes)
                {
                    Children = new()
                    {
                        StyleSheet
                    }
                },
                JSScript
            }
        };
        public static HtmlElement StyleSheet => new(
            "Таблица стилей",
            "style",
            new() {
                BlocksOfAttributes.StyleSheet
            });
        public static HtmlElement JSScript => new(
            "JavaScript скрипт",
            "script",
            new() { BlocksOfAttributes.Script });
        public static HtmlElement Input
        {
            get
            {
                var blocks = DivisionBlocksOfAttributes;
                blocks.Add(BlocksOfAttributes.Input);
                return new("Поле ввода", "input", blocks);
            }
        }
        public static HtmlElement DocumentHead => new(
            "Голова документа",
            "head",
new()
        )
        {
            // <meta charset="UTF-8">
            // <meta name="viewport" content="width=device-width, initial-scale=1.0">
            Children = new()
            {
                new("Мета. Кодировка", "meta", new() { new(new HashSet<Attribute>() {new("Мета. Кодировка", "charset", "UTF-8") }) }),
                new("Мета. Viewport", "meta", new()
                {
                    new(new HashSet<Attribute>() {
                        new("Мета. Содержимое", "content", "width=device-width, initial-scale=1.0"),
                    }),
                })
            }
        };

        public static HashSet<HtmlElement> GeneralElements => new()
        {
            Division,
            Image,
            Button,
            Input,
        };
    }
}