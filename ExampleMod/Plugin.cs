using System;
using UnityEngine.SceneManagement;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using ExampleMod.GamePatcher;
using ExampleMod.UI;

namespace ExampleMod;

[BepInPlugin(GUID, PluginName, PluginVersion)]
[BepInProcess("<EnterGameExeNameHere.exe>")]
public class ExamplePlugin : BasePlugin
{
    internal const string GUID = "com.Example.ExamplePlugin";
    internal const string PluginName = "Example Plugin";
    internal const string PluginVersion = "1.0.0";

    internal static ManualLogSource _staticLog;

    public static void LogMessage(object data, LogLevel logLevel = LogLevel.Info)
    {
        _staticLog?.Log(logLevel, data);
    }

    public override void Load()
    {
        _staticLog = Log;

        SceneManager.add_sceneLoaded(new Action<Scene, LoadSceneMode>((scene, loadSceneMode) =>
        {
            LogMessage($"Loaded Scene \"{scene.name}\" with mode {loadSceneMode}");
        }));

        LogMessage($"Plugin {GUID} loaded!");

        MenuOverlay.CreateInstance(this);
    }
}
