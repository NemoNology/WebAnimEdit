using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Implementations
{
    public class DivElement : HtmlElement
    {
        public override string Name => "div";

        public DivElement() : base()
        {
            Attributes.Add("", "");
        }
    }
}