using UnityEngine;

namespace ExampleMod.IMGUIWrapper;

public class IMHorizontalSlider(Rect position, float value, float leftValue, float rightValue) : IMControl
{
    public Rect Position { get; set; } = position;
    public float Value { get; set; } = value;
    public float LeftValue { get; set; } = leftValue;
    public float RightValue { get; set; } = rightValue;

    public override void Update() => Value = GUI.HorizontalSlider(Position, Value, LeftValue, RightValue);
}
