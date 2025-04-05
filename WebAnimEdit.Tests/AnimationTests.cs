using WebAnimEdit.Models.Animation;
using Frame = WebAnimEdit.Models.Animation.AnimationFrame<byte>;
using Clip = WebAnimEdit.Models.Animation.AnimationClip<byte>;

namespace WebAnimEdit.Tests;

public class AnimationTests
{
    private byte _bufferValue;

    [Test]
    public void ToAnimationClipTest()
    {
        var frame1 = new Frame(0, 0);
        var frame2 = new Frame(0, 1);
        var frame3 = new Frame(0, 2);
        var clip = new Clip(frame1, frame2, EasingFunctions.Linear);
        Assert.Multiple(() =>
        {
            Assert.That(frame1, Is.EqualTo(clip.StartFrame), "Start frame is not at start");
            Assert.That(frame2, Is.EqualTo(clip.EndFrame), "End frame is not at end");
        });
        clip.StartFrame = frame3;
        Assert.That(frame3, Is.EqualTo(clip.EndFrame), "End frame was not updated to new frame");
        clip.EndFrame = frame1;
        Assert.That(frame1, Is.EqualTo(clip.StartFrame), "Start frame was not updated to new frame");
    }

    [TestCase(0, 100)]
    public void ToAnimationClipCalculateWithLinearEasingTest(byte startValue, byte endValue)
    {
        const int startFrameNumber = 1, framesCount = 10;
        var frame1 = new Frame(startValue, startFrameNumber);
        var frame2 = new Frame(endValue, framesCount);
        var clip = new Clip(frame1, frame2, EasingFunctions.Linear);
        Action<byte> setBufferValue = value => _bufferValue = value;
        clip.OnValueCalculated += setBufferValue;
        for (var i = startFrameNumber; i <= framesCount; i++)
        {
            clip.ToCalculateFrame(i);
            var expectedValue = startValue + (endValue - startValue) * (i / 10f);
            Assert.That(_bufferValue, Is.EqualTo(expectedValue), "Value calculated wrong");
        }

        ;

        clip.OnValueCalculated -= setBufferValue;
    }
}