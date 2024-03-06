namespace Blazor_pwa.Models.Implementations
{
    public class Animation
    {
        public string Name { get; set; }
        public List<KeyFrame> KeyFrames { get; init; } = new();

        public Animation(string name)
        {
            Name = name;
        }
    }
}