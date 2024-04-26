using WebAnimEdit.Models.Enums;

namespace WebAnimEdit.Models.Implementations
{
    public class BlockOfProperties
    {
        /// <summary>
        /// Type of the block. Type is used to identify the block
        /// </summary>
        public BlockOfPropertiesType Type { get; init; }

        /// <summary>
        /// Dictionary of block properties, where property is name and value
        /// </summary>
        public Property[] Properties { get; init; }

        /// <summary>
        /// Constructor with type and properties parameters
        /// </summary>
        /// <param name="type">Type of the block</param>
        /// <param name="properties">Initial properties for block. If null, new empty dictionary will be created</param>
        public BlockOfProperties(BlockOfPropertiesType type, Property[] properties)
        {
            Type = type;
            Properties = properties;
        }
    }
}