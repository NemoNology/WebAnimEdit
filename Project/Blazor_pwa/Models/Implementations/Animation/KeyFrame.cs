namespace Blazor_pwa.Models.Implementations
{
    public struct KeyFrame
    {
        public int PercentValue { get; set; }
        public readonly Dictionary<string, string> ChangingProperties { get; }

        public KeyFrame()
        {
            ChangingProperties = new();
        }
    }
}