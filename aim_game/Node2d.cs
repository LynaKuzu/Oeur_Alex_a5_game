using Godot;
using System;
using System.Timers;

public partial class Node2d : Node2D
{
    // Called when the node enters the scene tree for the first time.
    [Export]
    RigidBody2D RigidBody2D;
	public override void _Ready()
	{
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        if (Input.IsActionJustReleased("shoot"))
        {
            PackedScene packedScene = ResourceLoader.Load<PackedScene>("res://prefabs/Duck.tscn");
            RigidBody2D newDuck = packedScene.Instantiate<RigidBody2D>();
            AddChild(newDuck);
            RandomNumberGenerator rng = new RandomNumberGenerator();
            float startX = rng.RandfRange(200, 1000);
            newDuck.Position = new Vector2(startX, 800);
        }
    }
}
