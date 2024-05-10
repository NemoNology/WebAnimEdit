using System.Xml;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace WebAnimEdit.Models.Implementations
{
    public static class HtmlElementExtentions
    {
        /// <summary>
        /// Remove first html element from html element children deeply, searching in all children 
        /// </summary>
        /// <param name="root">Html element from which another element will be removed</param>
        /// <param name="element">Html element that will be removed</param>
        public static void DeepRemoveFirstHtmlElement(this HtmlElement root, HtmlElement element)
        {
            if (root.Children.Count == 0)
                return;

            Queue<HashSet<HtmlElement>> buffer = new(root.Children.Count);
            buffer.Enqueue(root.Children);
            while (buffer.Count > 0)
            {
                var setBuffer = buffer.Dequeue();

                if (setBuffer.Contains(element))
                {
                    setBuffer.Remove(element);
                    return;
                }

                foreach (var el in setBuffer)
                {
                    if (el.Children.Count > 0)
                    {
                        buffer.Enqueue(el.Children);
                    }
                }
            }
        }

        public static HtmlElement WithAnotherAttributeValueByAttributeTag(
            this HtmlElement element,
            string attributeTag,
            string newAttributeValue)
        {
            foreach (var attribute in element.Attributes)
            {
                if (attribute.Tag == attributeTag)
                {
                    attribute.Value = newAttributeValue;
                    return element;
                }
            }

            return element;
        }

        public static RenderFragment GetSpecifiedInputFieldByValueType(this Attribute attribute)
        => attribute.ValueType switch
        {
            _ => builder =>
            {
                builder.OpenComponent<MudTextField<string>>(1);
                builder.AddAttribute(2, "Value",
                    EventCallback.Factory.CreateBinder<string>(
                        attribute, value => attribute.Value = value, attribute.Value));
                builder.AddAttribute(3, "Variant", Variant.Text);
                builder.AddAttribute(4, "Label", attribute.Name);
                builder.CloseComponent();
            }
        };

        public static XmlElement ToXml(this HtmlElement element, XmlDocument? doc = null)
        {
            doc ??= new();
            var el = doc.CreateElement(element.Tag);
            foreach (var attribute in element.Attributes)
            {
                bool hasParrentAttribute = !string.IsNullOrWhiteSpace(attribute.ParentAttributeTag);
                XmlAttribute attrBuffer;
                if (!hasParrentAttribute && string.IsNullOrWhiteSpace(attribute.Tag))
                {
                    el.InnerText = attribute.Value;
                    continue;
                }
                else if (hasParrentAttribute)
                {
                    attrBuffer = (el.Attributes.GetNamedItem(attribute.ParentAttributeTag!) as XmlAttribute)!;
                    if (attrBuffer is null)
                    {
                        attrBuffer = doc.CreateAttribute(attribute.ParentAttributeTag!);
                        attrBuffer.Value = $"{attribute.Tag}: {attribute.Value};";
                    }
                    else
                    {
                        attrBuffer.Value += $" {attribute.Tag}: {attribute.Value};";
                    }
                }
                else
                {
                    attrBuffer = doc.CreateAttribute(attribute.Tag);
                    attrBuffer.Value = attribute.Value;
                }
                el.Attributes.Append(attrBuffer);
            }
            foreach (var child in element.Children)
                el.AppendChild(child.ToXml(doc));

            return el;
        }

        public static string ToHtml(this HtmlElement element)
        => element.ToXml().OuterXml;
    }
}