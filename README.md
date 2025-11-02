# A BepInEx IL2CPP Template Project

## Introduction

This is a template project for creating BepInEx 6 mods for Unity engine (IL2CPP) games. This template is specifically designed for games that use Unity's IL2CPP build system.

IL2CPP (Intermediate Language to C++) is Unity's ahead-of-time compilation technology that converts .NET code to C++ and then to native platform code. This project provides the necessary setup to create mods for IL2CPP-based Unity games.

## LEGAL DISCLAIMER

BEFORE YOU START DEVELOPING PLUGINS/MODS FOR ANY GAME USING THIS TEMPLATE, YOU MUST OBTAIN EXPLICIT PERMISSION FROM THE GAME DEVELOPERS. CREATING AND DISTRIBUTING MODS WITHOUT OFFICIAL AUTHORIZATION MAY VIOLATE THE GAME'S END USER LICENSE AGREEMENT (EULA), TERMS OF SERVICE, AND/OR APPLICABLE LAWS, WHICH COULD RESULT IN LEGAL CONSEQUENCES, ACCOUNT BANS, OR OTHER PENALTIES.

THE AUTHOR OF THIS TEMPLATE PROVIDES THIS PROJECT FOR EDUCATIONAL PURPOSES ONLY AND ACCEPTS NO RESPONSIBILITY OR LIABILITY FOR ANY ISSUES THAT MAY ARISE FROM ITS USE. THIS INCLUDES, BUT IS NOT LIMITED TO:

- ANY DAMAGE TO YOUR FILES
- BANNING OF YOUR GAME ACCOUNT
- LEGAL ACTION TAKEN BY GAME DEVELOPERS OR PUBLISHERS
- ANY OTHER CONSEQUENCES RESULTING FROM THE CREATION, DISTRIBUTION, OR USE OF MODS DEVELOPED WITH THIS TEMPLATE

BY USING THIS TEMPLATE, YOU ACKNOWLEDGE THAT YOU ARE SOLELY RESPONSIBLE FOR ENSURING YOUR MODDING ACTIVITIES COMPLY WITH ALL APPLICABLE TERMS OF SERVICE, LICENSES, AND LAWS. YOU BEAR FULL RESPONSIBILITY FOR ANY AND ALL OUTCOMES RESULTING FROM YOUR USE OF THIS TEMPLATE. IF YOU DO NOT AGREE TO THESE TERMS OR ARE UNWILLING TO ASSUME ALL LEGAL AND PRACTICAL RISKS, YOU MUST IMMEDIATELY DELETE THIS PROJECT AND ALL ASSOCIATED FILES FROM YOUR SYSTEM.

## Installation Guide

### Prerequisites

- **BepInEx 6** installed in your game's root directory
- After installing BepInEx, run the game once to allow BepInEx to extract the necessary DLL files

### Setup Steps

1. **Copy the project folder**
   - Copy this entire project folder to your Unity game's root directory
   - After copying, your game directory should contain the mod folder (`ExampleMod`)

2. **Configure your mod**
   - Modify the plugin information (name, version, description, etc.) in the appropriate files
      - Rename the root folder, and change the namespaces in `.cs` files
      - Rename the `.csproj` file, and change the AssemblyName at `<AssemblyName>ExampleMod</AssemblyName>`
      - Enter game filename in ExampleMod/Plugin.cs:12 (`[BepInProcess("<EnterGameExeNameHere.exe>")]`)
      - Change GUID, PluginName and PluginVersion in ExampleMod/Plugin.cs:15-17
   - Update the `build` file in root folder and fill in any placeholder values

3. **Development tools**
   - You may need tools like **ILSpy** or **dnSpy** to analyze the game's assemblies and understand the code structure

### Building Your Mod

Once you've set up the project and written your code:

Execute `./build` from the project root
- The game should run with built dll. If not, check for any errors in output.
- The compiled dll is located in the output directory: `bin/Debug/netcoreapp6.0/`

### Getting Started with Development

- Study the game's existing assemblies using reverse engineering tools
- Reference BepInEx documentation for IL2CPP-specific development considerations
- Test your mod thoroughly before distribution
