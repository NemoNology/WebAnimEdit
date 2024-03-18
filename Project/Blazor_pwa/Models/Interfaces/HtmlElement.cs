using Blazor_pwa.Models.Emums;
using Blazor_pwa.Models.Implementations;

namespace Blazor_pwa.Models.Interfaces
{
    public abstract class HtmlElement
    {
        /// <summary>
        /// Type of the HTML element
        /// </summary>
        public abstract HtmlElementType Type { get; }
        /// <summary>
        /// Dictionary of element parameters as key-value pairs
        /// </summary>
        public Dictionary<string, string> Attributes { get; protected set; } = new();
        /// <summary>
        /// Dictionary of element style properties as key-value pairs
        /// </summary>
        public Dictionary<string, string> Style { get; protected set; } = new();
        /// <summary>
        /// List of element animations
        /// </summary>
        public Animation? Animation { get; protected set; } = null;

        public HtmlElement()
        {
            Style.Add("left", "0px");
            Style.Add("top", "0px");
            Style.Add("position", "absolute");
            Style.Add("z-index", "0");
            Style.Add("animation-duration", "1s");
        }
    }
}