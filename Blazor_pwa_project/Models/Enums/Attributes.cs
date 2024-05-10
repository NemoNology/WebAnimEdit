using Attribute = WebAnimEdit.Models.Implementations.Attribute;

namespace WebAnimEdit.Models.Enums
{
    public static class Attributes
    {
        public const string STYLEATTRIBUTETAG = "style";
        public const string ANIMATIONSTYLEATTRIBUTETAG = "to";

        public static Attribute Text => new(
            "Текст",
            "",
            "",
            AttributeValueType.None);
        public static Attribute FontSize => new(
            "Размер шрифта",
            "font-size",
            "14px",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute FontFamily => new(
            "Семейство шрифтов",
            "font-family",
            "\"Times New Roman\", Times, serif",
            AttributeValueType.None,
            STYLEATTRIBUTETAG);
        public static Attribute FontStyle => new(
            "Стиль шрифта",
            "font-style",
            "normal",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute FontWeight => new(
            "Толщина шрифта",
            "font-weight",
            "normal",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute FontColor => new(
            "Цвет шрифта",
            "color",
            "black",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute BackgroundColor => new(
            "Цвет заднего фона",
            "background-color",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute Padding => new(
            "Padding",
            "padding",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute Margin => new(
            "Margin",
            "margin",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute BorderThickness => new(
            "Толщина обводки",
            "border-width",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute BorderColor => new(
            "Цвет обводки",
            "border-color",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute BorderStyle => new(
            "Стиль обводки",
            "border-style",
            "solid",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute BorderCornerRadius => new(
            "Закругление обводки",
            "border-radius",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute PositionType => new(
            "Тип расположения",
            "position",
            "relative",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute PositionLeft => new(
            "Положение X",
            "left",
            "0px",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute PositionTop => new(
            "Положение Y",
            "top",
            "0px",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute Width => new(
            "Ширина",
            "width",
            "auto",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute Height => new(
            "Высота",
            "height",
            "auto",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute Rotation => new(
            "Поворот",
            "rotate",
            "none",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute Scale => new(
            "Маштаб",
            "scale",
            "none",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Attribute Class => new(
            "Классы таблицы стилей",
            "class",
            "",
            AttributeValueType.None);
        public static Attribute Style => new(
            "Стиль",
            STYLEATTRIBUTETAG,
            "",
            AttributeValueType.Style);
        public static Attribute AnimationStyle => new(
            "Стиль анимации",
            ANIMATIONSTYLEATTRIBUTETAG,
            "",
            AttributeValueType.Style);
        public static Attribute OnClick => new(
            "Обработчик события клика",
            "onclick",
            "",
            AttributeValueType.Script);
        public static Attribute OnMouseOver => new(
            "Обрабочик события наведения курсора",
            "onmouseover",
            "",
            AttributeValueType.Script);
        public static Attribute OnMouseOut => new(
            "Обрабочик события отведения курсора",
            "onmouseout",
            "",
            AttributeValueType.Script);
        public static Attribute OnKeyDown => new(
            "При нажатии на клавишу",
            "onkeydown",
            "",
            AttributeValueType.Script);
        public static Attribute StyleSheet => new(
            "Таблица стилей",
            "",
            "",
            AttributeValueType.Style);
        public static Attribute Script => new(
            "JavaScript скрипт",
            "",
            "",
            AttributeValueType.Script);
        public static Attribute ImageSource => new(
            "URL-источник изображения",
            "src",
            "",
            AttributeValueType.None
        );
        public static Attribute InputType => new(
            "Тип поля ввода",
            "type",
            "text",
            AttributeValueType.Value
        );
    }
}