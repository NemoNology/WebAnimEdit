namespace Blazor_project.WAsm.PWA.Models.Implementations
{
    public class Animation
    {
        public double Duration { get; set; }
        public CSSStyle To { get; set; }

        public Animation(CSSStyle style)
        {
            To = style;
        }
    }
}