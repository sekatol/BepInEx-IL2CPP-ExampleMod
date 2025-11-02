using UnityEngine;

namespace ExampleMod.IMGUIWrapper;

public class IMLabel(Rect position, string text) : IMControl
{
    public Rect Position { get; set; } = position;
    public string Text { get; set; } = text;

    public override void Update() => GUI.Label(Position, Text);
}
