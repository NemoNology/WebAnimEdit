namespace WebAnimEdit.Models.Enums
{
    public static class Properties
    {
        public const string STYLEATTRIBUTETAG = "style";
        public const string ANIMATIONSTYLEATTRIBUTETAG = "to";

        public static Implementations.Attribute FontSize => new(
            "Размер шрифта",
            "font-size",
            "14px",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute FontFamily => new(
            "Семейство шрифтов",
            "font-family",
            "\"Times New Roman\", Times, serif",
            AttributeValueType.None,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute FontStyle => new(
            "Стиль шрифта",
            "font-style",
            "normal",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute FontWeight => new(
            "Толщина шрифта",
            "font-weight",
            "normal",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute FontColor => new(
            "Цвет шрифта",
            "color",
            "black",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute BackgroundColor => new(
            "Цвет заднего фона",
            "background-color",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute Padding => new(
            "Padding",
            "padding",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute Margin => new(
            "Margin",
            "margin",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute BorderThickness => new(
            "Толщина обводки",
            "border-width",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute BorderColor => new(
            "Цвет обводки",
            "border-color",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute BorderStyle => new(
            "Стиль обводки",
            "border-style",
            "solid",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute BorderCornerRadius => new(
            "Закругление обводки",
            "border-radius",
            "unset",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute PositionType => new(
            "Тип расположения",
            "position",
            "relative",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute PositionLeft => new(
            "Положение X",
            "left",
            "0px",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute PositionTop => new(
            "Положение Y",
            "top",
            "0px",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute Width => new(
            "Ширина",
            "width",
            "auto",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute Height => new(
            "Высота",
            "height",
            "auto",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute Rotate => new(
            "Поворот",
            "rotate",
            "none",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute Scale => new(
            "Маштаб",
            "scale",
            "none",
            AttributeValueType.Value,
            STYLEATTRIBUTETAG);
        public static Implementations.Attribute Class => new(
            "Классы таблицы стилей",
            "class",
            "",
            AttributeValueType.None);
        public static Implementations.Attribute Style => new(
            "Стиль",
            STYLEATTRIBUTETAG,
            "",
            AttributeValueType.Style);
        public static Implementations.Attribute AnimationStyle => new(
            "Стиль анимации",
            ANIMATIONSTYLEATTRIBUTETAG,
            "",
            AttributeValueType.Style);
        public static Implementations.Attribute OnClick => new(
            "Обработчик события клика",
            "onclick",
            "",
            AttributeValueType.Script);
        public static Implementations.Attribute OnMouseOver => new(
            "Обрабочик события наведения курсора",
            "onmouseover",
            "",
            AttributeValueType.Script);
        public static Implementations.Attribute OnMouseOut => new(
            "Обрабочик события отведения курсора",
            "onmouseout",
            "",
            AttributeValueType.Script);
        public static Implementations.Attribute OnKeyDown => new(
            "При нажатии на клавишу",
            "onkeydown",
            "",
            AttributeValueType.Script);
        public static Implementations.Attribute StyleSheet => new(
            "Таблица стилей",
            "",
            "",
            AttributeValueType.Style);
        public static Implementations.Attribute Script => new(
            "JavaScript скрипт",
            "",
            "",
            AttributeValueType.Script);
        public static Implementations.Attribute ImageSource => new(
            "URL-источник изображения",
            "src",
            "",
            AttributeValueType.None);
    }
}