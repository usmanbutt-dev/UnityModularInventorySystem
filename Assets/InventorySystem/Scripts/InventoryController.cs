using UnityEngine;

public class InventoryController : MonoBehaviour {
    void Update() {
        if (Input.GetKeyDown(KeyCode.I)) {
            if (Inventory.Instance != null) {
                Inventory.Instance.ToggleInventory();
            }
            else {
                Debug.LogWarning("Inventory instance not found!");
            }
        }
    }
}