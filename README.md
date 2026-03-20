# SuperAdventure
SuperAdventure is a simple single-player Windows Forms role-playing game (RPG) written in C#. The project demonstrates a small game architecture with an `Engine` library for game logic and a WinForms UI in the `SuperAdventure` project.

## Features
- Tile-based movement between locations using directional buttons
- Quests with item-collection and reward mechanics
- Turn-based combat against monsters using weapons and healing potions
- Inventory and quest tracking presented in UI grids
- Simple loot, gold and experience progression

## Requirements
- Windows 10/11
- .NET 10 SDK
- Visual Studio 2022/2026 or the `dotnet` CLI
- C# 14 language features used

## Build and run
- Clone the repository:

  `git clone https://github.com/Jude-Santos-82/SuperAdventure.git`

- From Visual Studio: open `SuperAdventure.sln` and press F5 to build and run.

- Using the CLI (PowerShell):

  `dotnet build`
  `dotnet run --project SuperAdventure\SuperAdventure.csproj`

## Gameplay basics
- Movement: Use `North`, `East`, `South`, `West` to travel between locations.
- Locations: See the name and description in the location box. Some locations require specific items to enter.
- Quests: Pick up quests, collect required items and return to complete them for experience, gold and items.
- Combat: When a monster is present select a weapon and click `Use`. Use potions to heal.
- UI: Inventory and quests appear in bottom grids. Messages show combat and quest updates.

## Project structure
- `SuperAdventure/` — WinForms UI project with `SuperAdventure.cs` and designer assets.
- `Engine/` — Core game logic: `Player`, `World`, `Item`, `Monster`, `Quest` and related classes.

## Extending the game
- Add items, monsters and locations in the engine (look for `World` or data classes).
- Create new quests and reference them from locations.
- Extend the WinForms UI to show more player stats, add save/load or new mechanics.

## Troubleshooting
- Ensure the .NET 10 SDK is installed and Visual Studio is configured for that target.
- If designer issues occur, open the designer in Visual Studio to let it regenerate designer code.

## Contributing
Contributions welcome. Open issues or PRs on the upstream repository and follow standard GitHub workflows.

## License
Add a `LICENSE` file if you plan to publish or share the project widely.
