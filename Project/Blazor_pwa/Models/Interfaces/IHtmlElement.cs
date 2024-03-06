using Blazor_pwa.Models.Implementations;

namespace Blazor_pwa.Models.Interfaces
{
    public interface IHtmlElement
    {
        /// <summary>
        /// Name (Tag) of the HTML element
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Dictionary of element parameters as key-value pairs
        /// </summary>
        Dictionary<string, string> Parameters { get; }
        /// <summary>
        /// Dictionary of element style properties as key-value pairs
        /// </summary>
        Dictionary<string, string> Style { get; }
        /// <summary>
        /// List of element animations
        /// </summary>
        List<Animation> Animations { get; }
    }
}