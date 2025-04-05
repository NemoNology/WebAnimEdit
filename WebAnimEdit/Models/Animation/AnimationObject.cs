using System.Numerics;

namespace WebAnimEdit.Models.Animation;

public class AnimationObject(Vector2 position)
{
    public string Tag { get; set; } = "";
    public string Name { get; set; } = "";
    public Vector2 Position { get; set; } = position;
}