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
```

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

## 💡 Pattern Breakdown: Why & When to Use Them

Understanding *how* to write a pattern is good, but knowing *why* and *when* to use it is what makes a software architect. Here is the engineering philosophy behind each pattern in this repository:

### 1. Singleton Pattern
* **What It Does:** Ensures that only **one single instance** of a class exists in the scene and provides a global point of access to it.
* **Why Use It:** To prevent critical system conflicts. For example, if you accidentally have two `AudioManager` or `GameManager` instances running, your game systems will clash (e.g., playing two background tracks simultaneously).
* **When to Use It (The "Aha!" Moment):** When you find yourself needing to access a specific manager script from 20 different places in your codebase and you are tired of using `GameObject.Find()` or constantly dragging and dropping references in the Inspector.

### 2. Object Pool Pattern
* **What It Does:** Instead of constantly destroying (`Destroy`) and instantiating (`Instantiate`) objects, it pre-instantiates them, deactivates them into a "pool", and reuses them when needed.
* **Why Use It:** For crucial performance optimization. Constantly creating and destroying objects heavily taxes the CPU and triggers the Garbage Collector, causing noticeable FPS drops (stutters) during gameplay.
* **When to Use It (The "Aha!" Moment):** When you have objects that appear and disappear rapidly (like bullets, particle effects, or fast-spawning enemies), and you notice your game lagging during heavy action scenes. 

### 3. Factory Pattern
* **What It Does:** Delegates the complex task of instantiating objects from the main client code to a dedicated "Factory" class.
* **Why Use It:** To avoid cluttering your code with hundreds of `if-else` statements. The player simply asks for "an enemy," and the factory decides whether to spawn a zombie or a skeleton based on the current level.
* **When to Use It (The "Aha!" Moment):** When your code starts looking like an endless, ugly chain of `if (spellType == "Fire") { ... } else if (spellType == "Ice") { ... }`. That is your cue to move the creation logic into a factory and clean up your main code.

### 4. State Pattern
* **What It Does:** Separates the different "States" of a character or system (e.g., Idle, Chase, Attack) into completely independent, decoupled scripts.
* **Why Use It:** To prevent dumping all AI behaviors or player controls into one massive `Update` loop. When the character is in the "Attack" state, only the attack code runs, saving CPU cycles and keeping logic clean.
* **When to Use It (The "Aha!" Moment):** When your character or enemy code is flooded with boolean flags like `isAttacking`, `isFleeing`, `isPatrolling`, and fixing one animation accidentally breaks another. This pattern untangles that spaghetti code.

### 5. Observer Pattern
* **What It Does:** Creates an event-driven system where a publisher broadcasts an event (e.g., "I took damage!"), and interested listeners (UI, Audio, VFX) hear it and execute their own tasks.
* **Why Use It:** To completely decouple systems. The player's health script shouldn't know anything about the UI or Audio scripts.
* **When to Use It (The "Aha!" Moment):** When you find yourself adding `public UIHealthBar ui;` inside your player script just to update the health bar when the player gets hurt. Use this pattern whenever systems need to communicate without being tightly coupled.

### 6. Command Pattern
* **What It Does:** Encapsulates user inputs (keypresses) or AI actions into "Command Objects" rather than executing them immediately as raw functions.
* **Why Use It:** Once an input is treated as an object, you can send it over a network to other players, queue it up for fighting game combos, or store it in a list to rewind time (Undo functionality).
* **When to Use It (The "Aha!" Moment):** When you need to record a history of player actions (for an undo/replay feature) or when you need to send those exact inputs to a server in a multiplayer/networked game environment.

### 7. Strategy Pattern
* **What It Does:** Allows you to define a family of algorithms (e.g., different weapon firing modes) and interchange them dynamically at runtime without altering the main code.
* **Why Use It:** To build a modular, flexible, and easily expandable system. You can add dozens of new behaviors later without breaking or modifying existing code.
* **When to Use It (The "Aha!" Moment):** When you want to change a weapon's firing behavior instantly upon picking up a power-up, or when you foresee adding 10 different firing types later and want to avoid bloated `switch-case` blocks in the weapon controller.
