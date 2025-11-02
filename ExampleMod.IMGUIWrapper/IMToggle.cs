using UnityEngine;

namespace ExampleMod.IMGUIWrapper;

public class IMToggle(Rect position, string text, bool isChecked) : IMControl
{
    public Rect Position { get; set; } = position;
    public string Text { get; set; } = text;
    public bool IsChecked { get; set; } = isChecked;

    public override void Update() => IsChecked = GUI.Toggle(Position, IsChecked, Text);
}
