# Unity Design Patterns in C# 🎮

A practical collection of essential software design patterns implemented in Unity using C#. This repository serves as a playground and reference guide for writing clean, modular, scalable, and decoupled game code. 

Built with **Unity (Universal Render Pipeline - 2D)** to ensure modern performance standards and optimal rendering.

## 📂 Project Structure

To keep the architecture clean and easy to explore, each design pattern is isolated within its own folder containing its scripts and an interactive **Test Scene**.

```text
Assets/
└── Patterns/
    ├── 1_Singleton/       # Global access management
    ├── 2_ObjectPool/      # Performance optimization for instantiating
    ├── 3_Factory/         # Centralized object creation
    ├── 4_State/           # Clean AI behavior management
    ├── 5_Observer/        # Event-driven decoupled systems
    ├── 6_Command/         # Encapsulated actions (Undo/Redo mechanics)
    └── 7_Strategy/        # Interchangeable behaviors at runtime

🧩 Implemented Patterns & Use Cases
Here is a breakdown of the patterns included in this project and the specific game development problems they solve:

1. Singleton Pattern
Concept: Ensures only one instance of a class exists globally.

Use Case: Used for a generic AudioManager to prevent multiple audio systems from overlapping or destroying themselves during scene transitions.

2. Object Pool Pattern
Concept: Reuses inactive objects instead of constantly destroying and instantiating them to save CPU cycles and prevent Garbage Collection spikes.

Use Case: A spell-casting system where magic projectiles are recycled, keeping performance smooth even during heavy combat.

3. Factory Pattern
Concept: Delegates the creation of complex objects to a dedicated class.

Use Case: A SpellFactory that spawns different types of magic (Fire, Ice) via a common ISpell interface, completely hiding the creation logic from the player's input script.

4. State Pattern
Concept: Allows an object to alter its behavior when its internal state changes, avoiding massive if-else blocks.

Use Case: An Enemy AI controller switching seamlessly between IdleState (patrolling) and ChaseState (hunting the player) based on distance.

5. Observer Pattern
Concept: A publish/subscribe mechanism where objects notify others of state changes without being tightly coupled.

Use Case: A player health system using C# Action events. When the player takes damage, the UI Health Bar and the Audio System update automatically without needing direct references to the player script.

6. Command Pattern
Concept: Encapsulates a request as an object, allowing parameterization of clients with queues, requests, and operations.

Use Case: A movement system that stores player inputs as commands in a Stack, allowing for a complete Undo (rewind) mechanic.

7. Strategy Pattern
Concept: Defines a family of algorithms, encapsulates each one, and makes them interchangeable at runtime.

Use Case: A weapon system where the firing behavior (Single Shot vs. Spread Shot) can be swapped on the fly using the IWeaponStrategy interface.
