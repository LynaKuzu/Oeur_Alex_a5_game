using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class RigidBody2d : RigidBody2D
{
    // Called when the node enters the scene tree for the first time.
    float spd = 0;

    public override void _Ready()
	{
        Freeze = true;
        RandomNumberGenerator rng = new RandomNumberGenerator();
        float startX = rng.RandfRange(200, 1000);
        spd = rng.RandfRange(1, 10);
        Vector2 upPos = Position;
        upPos.X = startX;
        upPos.Y = 800;
        Position = upPos;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.

    public override void _Process(double delta)
	{
        Vector2 upPos = Position;
        if (Freeze)
        {
            upPos.Y -= spd;
            Position = upPos;
        }
        if (Position.Y < 0)
        {
            
        }
    }
    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventMouseMotion eventMouseMotion)
        {
            if (Position.DistanceTo(eventMouseMotion.Position) <= 25)
            {
                Freeze = false;
            }
        }
    }
}
