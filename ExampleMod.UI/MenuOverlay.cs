using System;
using UnityEngine;
using ExampleMod.IMGUIWrapper;
using ExampleMod.GamePatcher;

namespace ExampleMod.UI;

public class MenuOverlay(IntPtr ptr) : MonoBehaviour(ptr)
{
    KeyCode toggleVisibleKeyCode;

    IMWindow _mainWindow;

    int _buttonClickedTimes = 0;

    private void InitializeGUI()
    {
        toggleVisibleKeyCode = KeyCode.F5;
        _mainWindow = new(id: 100001, clientRect: new(10f, 10f, 640f, 480f), text: "Header", visible: true, childs: new()
        {
            ["label1"] = new IMLabel(
                position: new(10, 10, 100, 30),
                text: "Clicked 0 times!"
            ),
            ["button1"] = new IMButton(
                position: new(110, 10, 80, 30),
                text: "Click me!"
            ),
            ["toggle1"] = new IMToggle(
                position: new(10, 40, 80, 30),
                text: "t/f",
                isChecked: false
            ),
            ["label2"] = new IMLabel(
                position: new(10, 80, 80, 30),
                text: "0"
            ),
            ["slider1"] = new IMHorizontalSlider(
                position: new(10, 150, 200, 10),
                leftValue: 0,
                rightValue: 100,
                value: 20
            )
        });

        _mainWindow.OnUpdated += new(() =>
        {
            IMLabel label1 = _mainWindow.GetChild<IMLabel>("label1");
            IMButton button1 = _mainWindow.GetChild<IMButton>("button1");
            IMToggle toggle1 = _mainWindow.GetChild<IMToggle>("toggle1");
            IMLabel label2 = _mainWindow.GetChild<IMLabel>("label2");
            IMHorizontalSlider slider1 = _mainWindow.GetChild<IMHorizontalSlider>("slider1");

            if (button1.Clicked)
            {
                ExamplePlugin.LogMessage("Clicked!");
                _buttonClickedTimes++;
                label1.Text = $"Clicked {_buttonClickedTimes} times!";
            }

            label2.Text = slider1.Value.ToString();
            toggle1.Text = toggle1.IsChecked.ToString();

        });
    }

    void Start()
    {
        InitializeGUI();
    }

    public static void CreateInstance(ExamplePlugin loader)
    {
        MenuOverlay menuOverlay = loader.AddComponent<MenuOverlay>();
        DontDestroyOnLoad(menuOverlay.gameObject);
        menuOverlay.hideFlags |= HideFlags.HideAndDontSave;
    }

    public void Update()
    {
        if (Input.GetKeyDown(toggleVisibleKeyCode))
        {
            _mainWindow.Visible = !_mainWindow.Visible;
        }
    }

    public void OnGUI()
    {
        _mainWindow.Update();
    }
}
