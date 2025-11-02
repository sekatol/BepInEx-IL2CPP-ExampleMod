using System;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleMod.IMGUIWrapper;

public class IMModalWindow(int id, Rect clientRect, string text, bool visible, Dictionary<string, IMControl> childs)
{
    public int ID { get; set; } = id;
    public Rect ClientRect { get; set; } = clientRect;
    public string Text { get; set; } = text;
    public bool Visible { get; set; } = visible;
    public Dictionary<string, IMControl> Childs { get; set; } = childs;
    public event Action OnUpdated;

    public void Update()
    {
        if (!Visible)
            return;

        ClientRect = GUI.ModalWindow(ID, ClientRect, (Action<int>)WindowFunction, Text);
    }

    private void WindowFunction(int id)
    {
        foreach (var child in Childs)
        {
            child.Value.Update();
        }
        OnUpdated();
        GUI.DragWindow();
    }
}
