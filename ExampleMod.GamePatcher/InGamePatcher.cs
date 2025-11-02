using System;
using System.ComponentModel;
using UnityEngine;
using UB;

namespace ExampleMod.GamePatcher;

static class InGamePatcher
{
    static GameObject gameControllerGameObject { get; set; }

    public static void Bind()
    {
        gameControllerGameObject = GameObject.Find("custom");
        if (gameControllerGameObject is null)
        {
            throw new Exception("Cannot find GameController");
        }
    }
}
