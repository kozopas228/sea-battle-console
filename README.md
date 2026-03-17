# Sea Battle Console Game

This was the project I created as an assignment for my Software Design Patterns class at the University, the code has been almost not changed since those times.

This is a classic Battleship game implementation in C# for the console, features both PVP and PVE modes with automatic and manual ship placement options.

## Project Structure

```
SeaBattleTRPZ/
├── ConsoleApplication/       # Main console UI and game loop
│   └── Program.cs            # Entry point and rendering logic
├── GameLogic/                # Core game logic library
│   ├── Field.cs              # Game field model
│   ├── Ship.cs               # Ship model
│   ├── GameProcess.cs        # Game state and actions
│   ├── FieldGenerator.cs     # Random field generation
│   ├── FieldCreator.cs       # Manual field creation
│   ├── Memento/              # Memento pattern implementation
│   │   ├── IMemento.cs
│   │   ├── JsonMemento.cs
│   │   └── XmlMemento.cs
│   └── Util/
│       └── ShipException.cs
└── SeaBattle.Tests/          # Unit tests
    ├── FieldCreatorTests.cs
    ├── FieldGeneratorTests.cs
    └── GameProcessTests.cs
```

## Getting Started

**Requirements:** .NET 5.0 SDK or higher

```bash
# Clone and run
git clone https://github.com/yourusername/SeaBattleTRPZ.git
cd SeaBattleTRPZ
dotnet run --project ConsoleApplication

# Run tests
dotnet test
```

## Controls

### Menu Navigation
- Arrow Up/Down - Navigate menu options
- Enter - Select option
- Escape - Go back to main menu

### Ship Placement (Manual Mode)
- Arrow Up/Down - Select ship size
- Enter - Choose ship
- H - Place horizontally
- V - Place vertically
- Enter coordinates (e.g., A 1) to place ship

### Gameplay
- Arrow Keys - Move cursor on opponent's field
- Enter - Shoot selected cell
- R - Random shot
- N - Smart shot (near damaged ships)
- Escape - Return to menu

## Configuration

In the Settings menu, you can configure:
- **Field Size** - Grid dimensions (default: 10)
- **Play Mode** - PVP or PVE
- **Placement Mode** - Automatic or Manual
