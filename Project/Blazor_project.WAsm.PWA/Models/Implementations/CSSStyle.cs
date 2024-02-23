namespace Blazor_project.WAsm.PWA.Models.Implementations
{
    // TODO: make style property class: Name, value type (class: Type, measurement units), tag
    public class CSSStyle
    {
        public CSSStyle(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Top { get; set; }
        public double Left { get; set; }
        public double Bottom { get; set; }
        public double Right { get; set; }
        public double Rotate { get; set; }
        public double Scale { get; set; }
    }
}