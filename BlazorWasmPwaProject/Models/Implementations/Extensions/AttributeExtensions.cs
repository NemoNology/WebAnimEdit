using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace WebAnimEdit.Models.Implementations
{
    public static class AttributeExtensions
    {
        public static RenderFragment GetInputField(this Attribute attr)
        => attr.ValueType switch
        {
            // Enums.AttributeValueType.Value => _t,
            // Enums.AttributeValueType.Style => _t,
            // Enums.AttributeValueType.Script => _t,
            // Enums.AttributeValueType.Event => _t,
            Enums.AttributeValueType.Color => b =>
            {
                b.OpenComponent<MudColorPicker>(1);
                b.CloseComponent();
            }
            ,
            _ => b =>
            {
                b.OpenComponent<MudTextField<string>>(1);
                b.CloseComponent();
            }
        };
    }
}