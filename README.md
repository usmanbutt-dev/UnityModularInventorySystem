# 🎒 Unity Modular Inventory System

A flexible, open-source **modular inventory system** for Unity (2D or 3D), designed to be beginner-friendly, extensible, and game-ready. This system supports drag-and-drop interaction, stackable items, ScriptableObject-based item definitions, and a clean separation between data, logic, and UI.

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
│   ├── Scripts/
│   │   ├── ItemData.cs              // ScriptableObject definition
│   │   ├── InventorySlot.cs         // Slot logic and stacking
│   │   ├── InventoryManager.cs      // Central controller for the system
│   │   └── DragHandler.cs           // Handles UI drag-and-drop
│   ├── UI/
│   │   ├── InventorySlotUI.prefab   // Prefab for each inventory slot
│   │   └── InventoryPanel.prefab    // Main inventory UI container
│   ├── Data/
│   │   └── ExampleItem.asset        // Example item ScriptableObject
│   └── Demo/
│       ├── DemoPlayer.prefab
│       └── InventoryDemo.unity
├── Scenes/
│   └── InventoryDemo.unity
├── Packages/
├── ProjectSettings/
└── ...
```

---

## 🧠 How It Works

1. **ItemData.cs**
   - Defines item name, icon, description, and stack limit using ScriptableObjects.
2. **InventorySlot.cs**
   - Manages which item is held, the quantity, and operations like adding/removing stacks.
3. **InventoryManager.cs**
   - Centralized control that initializes inventory and links data with UI.
4. **InventorySlotUI.prefab**
   - Represents a visual inventory slot, auto-updates when the slot's data changes.
5. **DragHandler.cs**
   - Allows items to be dragged and dropped between slots with visual feedback.

This system follows the **separation of concerns** principle:
- Data is in ScriptableObjects
- Logic is handled by components
- UI is updated dynamically

---

## 🖼️ Screenshots

> (Add screenshots or GIFs of the inventory in use)

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