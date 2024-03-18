using Blazor_pwa.Models.Emums;

namespace Blazor_pwa.Models.Implementations
{
    public class HtmlElementsInfo
    {
        static public string GetHtmlElementNameByType(HtmlElementType type) =>
            type switch
            {
                HtmlElementType.Div => "Division",
                HtmlElementType.Image => "Image",
                _ => throw new NotImplementedException($"Element name for {type} type not implemented")
            };

        static public string GetHtmlElementTagByType(HtmlElementType type) =>
            type switch
            {
                HtmlElementType.Div => "div",
                HtmlElementType.Image => "img",
                _ => throw new NotImplementedException($"Element tag for {type} type not implemented")
            };
    }
}