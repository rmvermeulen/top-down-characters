using Godot;
using System;

public enum Type
{
    Hitman1,
    Hitman2,
    ManBlue,
    ManBrown,
    ManOld,
    ManRed,
    Robot1,
    Robot2,
    Soldier1,
    Soldier2,
    Survivor1,
    Survivor2,
    WomanGreen,
    WomanOld,
    Zombie1,
    Zombie2
}
public enum Animation
{
    Gun,
    Hold,
    Machine,
    Reload,
    Silencer,
    Stand
}
public class CharacterSprite : Sprite
{
    [Export]
    public Animation Animation { get; set; }
    [Export]
    public Type Type { get; set; }
    public override void _Ready()
    {
        ReloadTexture();
    }

    public void ReloadTexture()
    {
        Sprite s = this as Sprite;
        string folder = GetTypeFolder(Type) ?? "error";
        string prefix = GetTypeName(Type) ?? "error";
        string postfix = GetAnimationName(Animation) ?? "error";
        string path = $"res://assets/{folder}/{prefix}_{postfix}.png";
        s.Texture = GD.Load(path) as Texture;
    }

 
    private static string? GetAnimationName(Animation anim) =>
        anim switch
        {
            Animation.Gun => "gun",
            Animation.Hold => "hold",
            Animation.Machine => "machine",
            Animation.Reload => "reload",
            Animation.Silencer => "silencer",
            Animation.Stand => "stand",
            _ => null
        };
    private static string? GetTypeName(Type type) =>
        type switch
        {
            Type.Hitman1 => "hitman1",
            Type.Hitman2 => "hitman2",
            Type.ManBlue => "manBlue",
            Type.ManBrown => "manBrown",
            Type.ManOld => "manOld",
            Type.ManRed => "manRed",
            Type.Robot1 => "robot1",
            Type.Robot2 => "robot2",
            Type.Soldier1 => "soldier1",
            Type.Soldier2 => "soldier2",
            Type.Survivor1 => "survivor1",
            Type.Survivor2 => "survivor2",
            Type.WomanGreen => "womanGreen",
            Type.WomanOld => "womanOld",
            Type.Zombie1 => "zombie1",
            Type.Zombie2 => "zombie2",
            _ => null
        };
    private static string? GetTypeFolder(Type type) =>
        type switch
        {
            Type.Hitman1 => "Hitman 1",
            Type.Hitman2 => "Hitman 2",
            Type.ManBlue => "Man Blue",
            Type.ManBrown => "Man Brown",
            Type.ManOld => "Man Old",
            Type.ManRed => "Man Red",
            Type.Robot1 => "Robot 1",
            Type.Robot2 => "Robot 2",
            Type.Soldier1 => "Soldier 1",
            Type.Soldier2 => "Soldier 2",
            Type.Survivor1 => "Survivor 1",
            Type.Survivor2 => "Survivor 2",
            Type.WomanGreen => "Woman Green",
            Type.WomanOld => "Woman Old",
            Type.Zombie1 => "Zombie 1",
            Type.Zombie2 => "Zombie 2",
            _ => null
        };
}
