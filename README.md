# 🎒 Unity Modular Inventory System

A flexible, open-source **modular inventory system** for Unity (2D or 3D), designed to be beginner-friendly, extensible, and game-ready. This system supports stackable items, ScriptableObject-based item definitions, and a clean separation between data, logic, and UI.

---

## 📌 Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [How It Works](#how-it-works)
- [Screenshots](#screenshots)
- [Future Improvements](#future-improvements)
- [Contributing](#contributing)
- [License](#license)
- [Author](#author)

---

## ✨ Features

- ✅ Modular and scalable design
- 🧩 Uses ScriptableObjects for item data
- 📦 Inventory slot logic with support for:
  - Stackable items
  - Quantity display
  - Empty slot handling
- 🖱️ Drag-and-drop item interaction with basic UI
- 🎮 Ready-to-run demo scene included
- 🛠️ Easily extendable for RPGs, survival, crafting, or loot-based games
- 📁 Clean folder structure for production use

---

## 🚀 Getting Started

### Prerequisites

- Unity 6000.0.50f1 (or compatible newer versions)
- A basic understanding of Unity (GameObjects, Components, ScriptableObjects)

### 1. Clone the Repository

```bash
git clone https://github.com/usmanbutt-dev/UnityModularInventorySystem.git
```

Or download the ZIP from the GitHub page and extract it.

### 2. Open in Unity

- Open **Unity Hub**
- Click **"Open"** and select the project folder

### 3. Run the Demo

- Go to: `Assets/Scenes/InventoryDemo.unity`
- Press **Play** in the Unity Editor
- Interact with the inventory using the mouse (drag, stack, drop)

---

## 🗂️ Project Structure

```
Assets/
├── InventorySystem/
│   ├── Items/
│   │   ├── Apple.asset
│   │   ├── Axe.asset
│   │   ├── Bow.asset
│   │   └── Sword.asset
│   ├── Prefabs/
│   │   ├── Apple Prefab.prefab
│   │   ├── Axe Prefab.prefab
│   │   ├── Bow Prefab.prefab
│   │   ├── Complete Inventory Prefab.prefab
│   │   ├── Item UI Prefab.prefab
│   │   ├── ItemDrop Prefab.prefab
│   │   └── Sword Prefab.prefab
│   ├── Scripts/
│   │   ├── Inventory.cs
│   │   ├── InventoryController.cs
│   │   ├── Item.cs
│   │   ├── ItemPickup.cs
│   │   └── ItemUI.cs
├── Scenes/
│   └── InventoryDemo.unity
├── Packages/
├── ProjectSettings/
└── ...
```

---

## 🧠 How It Works

1. **Item.cs**  
   - A `ScriptableObject` that defines the core properties of each item:  
     `itemName`, `icon`, `description`, `isStackable`, and `maxStack`.  
   - Stored under `Assets/InventorySystem/Items/`.

2. **Inventory.cs**  
   - Manages a list of picked-up items.  
   - Adds new items to the inventory UI using the `Item UI Prefab`.  
   - Handles stackable logic: increases count if an item already exists and is under max stack.

3. **ItemPickup.cs**  
   - Attached to in-world item prefabs (e.g., `Apple Prefab`, `Sword Prefab`).  
   - Detects collision with the player and sends the item to `Inventory`.

4. **ItemUI.cs**  
   - Attached to UI items instantiated in the inventory (`Item UI Prefab`).  
   - Handles click actions:
     - **Left Click**: Uses the item (e.g., logs "Used item: Apple").
     - **Right Click**: Drops the item into the world near the player using `ItemDrop Prefab`.

5. **ItemDrop Prefab**  
   - A 2D/3D drop version of the item that spawns when an item is dropped.  
   - Retains the original `Item` data and can be picked up again.


This system follows the **separation of concerns** principle:
- Data is in ScriptableObjects
- Logic is handled by components
- UI is updated dynamically

---

## 🖼️ Screenshots

![Screenshot](Assets/ReadmeImages/Screenshot.png)
![Project Window](Assets/ReadmeImages/ProjectWindow.png)


---

## 🛣️ Future Improvements

Planned features for future versions:

- ✅ Tooltip system for item details on hover
- 🔄 Right-click item context menu (e.g., use, drop, examine)
- 🧪 Inventory saving/loading (JSON or PlayerPrefs)
- 📁 Equipment system integration (armor, weapons)
- 🎨 Customizable UI themes
- 🔁 Hotbar / quick-access bar
- 🐛 Bug tracking system via GitHub Issues

---

## 🧑‍💻 Contributing

Contributions are welcome! Whether it's:

- Adding new features
- Fixing bugs
- Improving UI/UX
- Writing better documentation

Please fork the repo, create a new branch, and submit a Pull Request.

---

## 📄 License

This project is licensed under the MIT License.  
You can freely use, modify, and distribute it with credit. See the [LICENSE](LICENSE) file for full terms.

---

## 👨‍🎓 Author

**Muhammad Usman Butt**  
Unity Developer | VR & 2D/3D Game Design  
GitHub: [@usmanbutt-dev](https://github.com/usmanbutt-dev)  
LinkedIn: [linkedin.com/in/usmanbutt-dev](https://linkedin.com/in/usmanbutt-dev)

---

## ⭐ Star This Project

If you found this project helpful or inspiring, consider starring it on GitHub.  
It helps others discover it and keeps the project alive!
