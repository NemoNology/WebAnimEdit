using Blazor_pwa.Models.Emums;
using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Enums
{
    public static class HtmlElements
    {
        public static HtmlElement Division => new(HtmlElementType.Div);
        public static HtmlElement Image => new(HtmlElementType.Image, new() {
            {"src", "Вставьте сюда URL-адрес изображения"},
            {"alt", "Вставьте сюда альтернативный текст"},
            });
    }
}