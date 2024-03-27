using Blazor_pwa.Models.Emums;
using Blazor_pwa.Models.Enums;
using Blazor_pwa.Models.Implementations;

namespace Blazor_pwa.Models.Interfaces
{
    public class HtmlElement
    {
        /// <summary>
        /// Type of the HTML element
        /// </summary>
        public HtmlElementType Type { get; private set; }

        public Dictionary<string, string> Attributes { get; private set; } = new();
        public Dictionary<string, string> Style { get; private set; } = new();
        public Dictionary<string, string> AnimationStyle { get; private set; } = new();
    }
}