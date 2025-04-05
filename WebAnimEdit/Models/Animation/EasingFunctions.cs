using System.ComponentModel.DataAnnotations;
using System.Numerics;

// ReSharper disable InconsistentNaming

namespace WebAnimEdit.Models.Animation;

public static class EasingFunctions
{
    public static TNumberValue Linear<TNumberValue>(TNumberValue startValue, TNumberValue endValue,
        [Range(0f, 1f)] TNumberValue animationProgressPercentage)
        where TNumberValue : struct, INumber<TNumberValue>
    {
        return startValue + (endValue - startValue) * animationProgressPercentage;
    }
}