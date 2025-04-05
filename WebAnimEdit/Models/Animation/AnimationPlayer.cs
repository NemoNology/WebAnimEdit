using System.Numerics;

namespace WebAnimEdit.Models.Animation;

public class AnimationPlayer<TNumberValue>(params List<AnimationClip<TNumberValue>> animations)
    where TNumberValue : struct, INumber<TNumberValue>
{
    public bool IsPlaying { get; set; }

    /// <summary>
    ///     Current frame number of animation
    /// </summary>
    public int CurrentFrameNumber { get; set; }

    /// <summary>
    ///     Animation duration in frames count
    /// </summary>
    public int AnimationDuration { get; set; }

    public List<AnimationClip<TNumberValue>> AnimationClips { get; set; } = animations;

    /// <summary>
    ///     Resume whole animation
    /// </summary>
    public void ToPlay()
    {
        IsPlaying = true;
    }

    /// <summary>
    ///     Pause whole animation
    /// </summary>
    public void ToPause()
    {
        IsPlaying = false;
    }

    public Task ToUpdate()
    {
        while (IsPlaying)
            // Godot like update
            if (CurrentFrameNumber < AnimationDuration)
            {
                ToSeek(CurrentFrameNumber);
                CurrentFrameNumber++;
            }

        return Task.CompletedTask;
    }

    /// <summary>
    ///     Calculate animation objects values for specified elapsed time
    /// </summary>
    public void ToSeek(int frameNumber)
    {
        foreach (var animationClip in AnimationClips) animationClip.ToCalculateFrame(frameNumber);
    }
}