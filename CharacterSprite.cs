using Godot;
using System;

public enum Type
{
    Hitman1, Hitman2,
    ManBlue, ManBrown, ManOld, ManRed,
    Robot1, Robot2, Soldier1, Soldier2,
    Survivor1, Survivor2,
    WomanGreen, WomanOld,
    Zombie1, Zombie2

}
public enum Animation
{
    Gun, Hold, Machine, Reload, Silencer, Stand
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
        string folder = GetTypeFolder(Type);
        string prefix = GetTypeName(Type);
        string postfix = GetAnimationName(Animation);
        string path = $"res://assets/{folder}/{prefix}_{postfix}.png";
        s.Texture = GD.Load(path) as Texture;
    }
    private static string GetAnimationName(Animation anim)
    {
        switch (anim)
        {
            case Animation.Gun: return "gun";
            case Animation.Hold: return "hold";
            case Animation.Machine: return "machine";
            case Animation.Reload: return "reload";
            case Animation.Silencer: return "silencer";
            case Animation.Stand: return "stand";
        };
        return "";
    }
    private static string GetTypeName(Type type)
    {
        switch (type)
        {
            case Type.Hitman1: return "hitman1";
            case Type.Hitman2: return "hitman2";
            case Type.ManBlue: return "manBlue";
            case Type.ManBrown: return "manBrown";
            case Type.ManOld: return "manOld";
            case Type.ManRed: return "manRed";
            case Type.Robot1: return "robot1";
            case Type.Robot2: return "robot2";
            case Type.Soldier1: return "soldier1";
            case Type.Soldier2: return "soldier2";
            case Type.Survivor1: return "survivor1";
            case Type.Survivor2: return "survivor2";
            case Type.WomanGreen: return "womanGreen";
            case Type.WomanOld: return "womanOld";
            case Type.Zombie1: return "zombie1";
            case Type.Zombie2: return "zombie2";
        };
        return "";
    }
    private static string GetTypeFolder(Type type)
    {
        switch (type)
        {
            case Type.Hitman1: return "Hitman 1";
            case Type.Hitman2: return "Hitman 2";
            case Type.ManBlue: return "Man Blue";
            case Type.ManBrown: return "Man Brown";
            case Type.ManOld: return "Man Old";
            case Type.ManRed: return "Man Red";
            case Type.Robot1: return "Robot 1";
            case Type.Robot2: return "Robot 2";
            case Type.Soldier1: return "Soldier 1";
            case Type.Soldier2: return "Soldier 2";
            case Type.Survivor1: return "Survivor 1";
            case Type.Survivor2: return "Survivor 2";
            case Type.WomanGreen: return "Woman Green";
            case Type.WomanOld: return "Woman Old";
            case Type.Zombie1: return "Zombie 1";
            case Type.Zombie2: return "Zombie 2";
        };
        return "";
    }
}
