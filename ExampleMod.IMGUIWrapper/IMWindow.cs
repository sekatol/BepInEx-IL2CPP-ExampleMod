using System;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleMod.IMGUIWrapper;

public class IMWindow(int id, Rect clientRect, string text, bool visible, Dictionary<string, IMControl> childs) : IMControl
{
    public int ID { get; set; } = id;
    public Rect ClientRect { get; set; } = clientRect;
    public string Text { get; set; } = text;
    public bool Visible { get; set; } = visible;
    public Dictionary<string, IMControl> Childs { get; set; } = childs;
    public event Action OnUpdated;

    public override void Update()
    {
        if (!Visible)
            return;

        ClientRect = GUI.Window(ID, ClientRect, (Action<int>)WindowFunction, Text);
    }

    public T GetChild<T>(string name) where T : IMControl
    {
        return Childs[name] as T;
    }

    private void WindowFunction(int id)
    {
        foreach (var child in Childs.Values)
        {
            child.Update();
        }
        OnUpdated();
        GUI.DragWindow();
    }
}
