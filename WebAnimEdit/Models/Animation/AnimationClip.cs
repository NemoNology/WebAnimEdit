using System.Numerics;

namespace WebAnimEdit.Models.Animation;

public class AnimationClip<TNumberValue>
    where TNumberValue : struct, INumber<TNumberValue>
{
    private AnimationFrame<TNumberValue> _startFrame, _endFrame;

    public AnimationClip(AnimationFrame<TNumberValue> startFrame, AnimationFrame<TNumberValue> endFrame,
        Func<TNumberValue, TNumberValue, TNumberValue, TNumberValue> easingFunction)
    {
        if (startFrame.AnimationFrameNumber < endFrame.AnimationFrameNumber)
            (_startFrame, _endFrame) = (startFrame, endFrame);
        else
            (_startFrame, _endFrame) = (endFrame, startFrame);

        EasingFunction = easingFunction;
    }

    public AnimationFrame<TNumberValue> StartFrame
    {
        get => _startFrame;
        set
        {
            if (value.AnimationFrameNumber > _endFrame.AnimationFrameNumber)
                (_startFrame, _endFrame) = (_endFrame, value);
            else _startFrame = value;
        }
    }

    public AnimationFrame<TNumberValue> EndFrame
    {
        get => _endFrame;
        set
        {
            if (value.AnimationFrameNumber < _startFrame.AnimationFrameNumber)
                (_startFrame, _endFrame) = (value, _startFrame);
            else _endFrame = value;
        }
    }

    public Func<TNumberValue, TNumberValue, TNumberValue, TNumberValue> EasingFunction { get; set; }

    public event Action<TNumberValue>? OnValueCalculated;

    public void ToCalculateFrame(int frameNumber)
    {
        if (frameNumber < _startFrame.AnimationFrameNumber || frameNumber > _endFrame.AnimationFrameNumber)
            return;
        var animationProgressPercentage = (TNumberValue)((frameNumber - _startFrame.AnimationFrameNumber) /
                                                         (float)(_endFrame.AnimationFrameNumber -
                                                                 _startFrame.AnimationFrameNumber) as object);
        OnValueCalculated?.Invoke(EasingFunction(_startFrame.Value, _endFrame.Value, animationProgressPercentage));
    }
}