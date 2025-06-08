using UnityEngine;

public class Inventory : MonoBehaviour {
    public static Inventory Instance {get; private set; }

    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void ToggleInventory() {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
