using System.Numerics;

namespace WebAnimEdit.Models.Animation;

public class AnimationFrame<TNumberValue>(
    TNumberValue value,
    int animationFrameNumber)
    where TNumberValue : struct, INumber<TNumberValue>
{
    /// <summary>
    ///     Value of animation object property at a given time
    /// </summary>
    public TNumberValue Value { get; set; } = value;

    /// <summary>
    ///     Animation frame number
    /// </summary>
    public int AnimationFrameNumber { get; set; } = animationFrameNumber;
}