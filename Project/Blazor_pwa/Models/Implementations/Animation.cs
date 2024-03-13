namespace Blazor_pwa.Models.Implementations
{
    public class Animation
    {
        public string Name { get; set; }
        public Dictionary<string, string> Transform { get; private set; } = new();

        public Animation(string name)
        {
            Name = name;
            Transform.Add("translateX", "0px");
            Transform.Add("translateY", "0px");
            Transform.Add("scaleX", "1");
            Transform.Add("scaleY", "1");
            Transform.Add("rotate", "0deg");
        }
    }
}