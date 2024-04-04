using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Implementations
{
    public class Project
    {
        public List<HtmlElement> Elements { get; private set; } = new();
    }
}