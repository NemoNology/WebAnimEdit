using WebAnimEdit.Models.Enums;

namespace WebAnimEdit.Models.Implementations
{
    public class Attribute
    {
        /// <summary>
        /// Name of property. Used for UI display
        /// </summary>
        public string Name { get; init; }
        /// <summary>
        /// ID/Tag of the property.
        /// Property is attribute or some parent attribute value, so it need tag 
        /// </summary>
        public string Tag { get; init; }
        /// <summary>
        /// Parent attribute tag.
        /// If it is null, property is whole attribute.
        /// Otherwise - porperty is some value of parent attribute
        /// </summary>
        /// <example>
        /// <code>
        /// ParentAttributeTag is null => $"{Tag}={Value}"
        /// ParentAttributeTag is "style" => $"style='{Tag}: {Value};'"
        /// </code>
        /// </example>
        public string? ParentAttributeTag { get; init; }
        /// <summary>
        /// Value of attribute
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Value type of attribute.
        /// Used for autocompletion
        /// </summary>
        public AttributeValueType ValueType { get; init; }
        /// <summary>
        /// Returns true if attribute will be convert into text of html-element
        /// Otherwise - false
        /// </summary>
        public bool IsTextAttribute =>
            string.IsNullOrWhiteSpace(Tag)
            && string.IsNullOrWhiteSpace(ParentAttributeTag);

        public Attribute(
            string name,
            string tag,
            string value,
            AttributeValueType valueType,
            string? parentAttributeTag = null)
        {
            Name = name;
            Tag = tag;
            ParentAttributeTag = parentAttributeTag;
            Value = value;
            ValueType = valueType;
        }
    }
}