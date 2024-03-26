using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Implementations
{
    public class Project
    {
        public string Title { get; set; }
        public List<AbstractHtmlElement> Elements { get; private set; } = new();
        public List<Animation> Animations { get; private set; } = new();

        public Project(string title)
        {
            Title = title;
        }
    }
}