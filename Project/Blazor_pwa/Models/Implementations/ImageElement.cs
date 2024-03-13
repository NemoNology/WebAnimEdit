using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Implementations
{
    public class ImageElement : HtmlElement
    {
        public override string Name => "img";

        public ImageElement(
            string src = "Введите адрес изображения",
            string alt = "Введите название изображения") : base()
        {
            Attributes.Add("src", src);
            Attributes.Add("alt", alt);
        }
    }
}