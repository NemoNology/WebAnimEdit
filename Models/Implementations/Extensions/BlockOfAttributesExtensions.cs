using MudBlazor;
using WebAnimEdit.Models.Enums;

namespace WebAnimEdit.Models.Implementations
{
    public static class BlockOfAttributesExtensions
    {
        public static string GetIcon(this BlockOfAttributes block)
            => block.Type switch
            {
                BlockOfAttributesType.Text => Icons.Material.Filled.TextFields,
                BlockOfAttributesType.Shape => Icons.Material.Filled.FormatShapes,
                BlockOfAttributesType.Transform => Icons.Material.Filled.Transform,
                BlockOfAttributesType.Style => Icons.Material.Filled.Style,
                BlockOfAttributesType.Event => "<g id='SVGRepo_iconCarrier'><path d='M18,11.74a1,1,0,0,0-.52-.63L14.09,9.43,15,3.14a1,1,0,0,0-1.78-.75l-7,9a1,1,0,0,0-.17.87,1,1,0,0,0,.59.67l4.27,1.71L10,20.86a1,1,0,0,0,.63,1.07A.92.92,0,0,0,11,22a1,1,0,0,0,.83-.45l6-9A1,1,0,0,0,18,11.74Z'></path></g>",
                BlockOfAttributesType.StyleSheet => Icons.Material.Filled.Css,
                BlockOfAttributesType.Script => Icons.Material.Filled.Javascript,
                BlockOfAttributesType.Input => Icons.Material.Filled.Javascript,
                BlockOfAttributesType.Image => Icons.Material.Filled.Javascript,
                _ => Icons.Material.Filled.DashboardCustomize
            };

        public static HashSet<Attribute> GetAttributes(this BlockOfAttributes block)
        => block.Type switch
        {
            BlockOfAttributesType.Text => new()
            {
                Attributes.Text,
                Attributes.FontSize,
                Attributes.FontFamily,
                Attributes.FontStyle,
                Attributes.FontWeight,
                Attributes.FontColor,
            },
            BlockOfAttributesType.Shape => new()
            {
                Attributes.BackgroundColor,
                Attributes.Padding,
                Attributes.Margin,
                Attributes.BorderThickness,
                Attributes.BorderColor,
                Attributes.BorderStyle,
                Attributes.BorderCornerRadius,
            },
            BlockOfAttributesType.Transform => new()
            {
                Attributes.PositionType,
                Attributes.PositionLeft,
                Attributes.PositionTop,
                Attributes.Width,
                Attributes.Height,
                Attributes.Rotation,
                Attributes.Scale,
            },
            BlockOfAttributesType.Style => new()
            {
                Attributes.Class,
                Attributes.Style,
            },
            BlockOfAttributesType.Event => new()
            {
                Attributes.OnClick,
                Attributes.OnMouseOver,
                Attributes.OnMouseOut,
                Attributes.OnKeyDown,
            },
            BlockOfAttributesType.StyleSheet => new()
            {
                Attributes.StyleSheet,
            },
            BlockOfAttributesType.Script => new()
            {
                Attributes.Script,
            },
            BlockOfAttributesType.Input => new()
            {
                Attributes.InputType,
                Attributes.Value,
                Attributes.ID,
                Attributes.Name,
                Attributes.Max,
                Attributes.Min,
                Attributes.Step,
            },
            BlockOfAttributesType.Image => new()
            {
                Attributes.ImageSource,
                Attributes.AlternativeText,
            },
            _ => new(2),
        };

        public static string GetToolTip(this BlockOfAttributes block)
        => block.Type switch
        {
            BlockOfAttributesType.Text => "Текст",
            BlockOfAttributesType.Shape => "Форма",
            BlockOfAttributesType.Transform => "Преращение",
            BlockOfAttributesType.Style => "Стиль",
            BlockOfAttributesType.Event => "События",
            BlockOfAttributesType.StyleSheet => "Таблица стилей",
            BlockOfAttributesType.Script => "Скрипт",
            BlockOfAttributesType.Input => "Ввод",
            BlockOfAttributesType.Image => "Изображение",
            _ => "Пользовательский"
        };
    }
}