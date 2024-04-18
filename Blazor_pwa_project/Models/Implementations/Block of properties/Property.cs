using Blazor_pwa_project.Models.Enums;

namespace Blazor_pwa_project.Models.Implementations
{
    public class Property
    {
        /// <summary>
        /// Type of property
        /// </summary>
        public PropertyType Type { get; set; }
        /// <summary>
        /// Name of property
        /// </summary>
        public string Name { get; set; }
        public string Value { get; set; }

        public Property(PropertyType type, string name, string value = "")
        {
            Type = type;
            Name = name;
            Value = value;
        }
    }
}