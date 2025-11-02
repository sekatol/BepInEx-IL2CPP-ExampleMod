using UnityEngine;

namespace ExampleMod.IMGUIWrapper;

public class IMButton(Rect position, string text) : IMControl
{
    public Rect Position { get; set; } = position;
    public string Text { get; set; } = text;
    public bool Clicked { get; set; }

    public override void Update() => Clicked = GUI.Button(Position, Text);
}
