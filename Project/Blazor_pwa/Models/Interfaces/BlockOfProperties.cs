using Blazor_pwa.Models.Emums;

namespace Blazor_pwa.Models.Interfaces
{
    public abstract class BlockOfProperties
    {
        /// <summary>
        /// Type of the block. Type is used to identify the block
        /// </summary>
        public abstract BlockOfPropertiesType Type { get; }

        /// <summary>
        /// Dictionary of block properties, where property is name and value
        /// </summary>
        public Dictionary<string, string> Properties { get; private set; } = new();
    }
}