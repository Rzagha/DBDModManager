# DBD Mod Manager

## Requirements

* **.NET 9 SDK** — [https://dotnet.microsoft.com/en-us/download/dotnet/9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

## Features

* **Multi-Platform Support**: Works with Steam, Epic Games Store, and Xbox / Windows Store versions of DBD.
* **Profiles**: Create and switch between preset mod configurations.
* **Themes**: Includes Eclipsed, Isolumia, and Girl Mode.
* **Mod Installation**: Supports `.pak`, `.sig`, `.ucas`, `.utoc` and auto-generates missing `.sig` files.
* **Archive Support**: Reads `.zip`, `.rar`, and `.mmpackage` archives without manual extraction.
* **Mod Cleaner**: Removes installed mods (chunks > 6000) without affecting base game files.
* **Search**: Quickly filter mods in the repository.
* **Quick Management**: Refresh repository, save presets, and bulk enable/disable mods.
* **Direct Uninstall**: Uninstall mods directly through the mod manager.

## How to Use

1. Select your DBD installation path (Steam, Epic, or Xbox).
2. Select your mod repository folder (No need to extract the mods).
3. Enable or disable mods using the mod cards or bulk selection options.
4. Refresh to reload the directory without losing selections.
5. Apply changes to install mods, or use Clean Game to return to vanilla.
6. Save your current selections as a preset and load them anytime.
7. Right click mod cards to uninstall unwanted mods from the mods directory.

## Building from Source

Requires **.NET 9.0 (Windows Desktop)**.

1. Open `DbdModManager.csproj` in Visual Studio or another IDE.
2. Restore NuGet packages and build for `x64`.
3. The executable will be in `bin/Release` or `bin/Debug`.

## Modding

A **PakBypass** is required for DBD modding. Get it at:
https://eclipsed.top/shop



