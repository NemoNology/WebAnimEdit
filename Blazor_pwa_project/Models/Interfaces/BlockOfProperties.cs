using Blazor_pwa.Models.Emums;

namespace Blazor_pwa.Models.Interfaces
{
    public class BlockOfProperties
    {
        /// <summary>
        /// Type of the block. Type is used to identify the block
        /// </summary>
        public BlockOfPropertiesType Type { get; private set; }

        /// <summary>
        /// Dictionary of block properties, where property is name and value
        /// </summary>
        public Dictionary<string, string> Properties { get; private set; }

        /// <summary>
        /// Constructor with type and properties parameters
        /// </summary>
        /// <param name="type">Type of the block</param>
        /// <param name="properties">Initial properties for block. If null, new empty dictionary will be created</param>
        public BlockOfProperties(BlockOfPropertiesType type, Dictionary<string, string>? properties = null)
        {
            Type = type;
            Properties = properties ?? new();
        }
    }
}