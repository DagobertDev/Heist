using Godot;

namespace Heist;

public class Character : Sprite
{
    [Export(PropertyHint.Range, "2000")]
    public int Speed { get; set; } = 100;

    public override void _Process(float delta)
    {
        var direction = Input.GetVector(
            InputAction.MoveLeft, 
            InputAction.MoveRight, 
            InputAction.MoveUp, 
            InputAction.MoveDown);
        Position += direction * Speed * delta;
    }        
}
