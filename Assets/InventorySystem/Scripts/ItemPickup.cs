using UnityEngine;

public class ItemPickup : MonoBehaviour {
    public Item item; // Drag your item asset here in the Inspector

    private void OnTriggerEnter2D(UnityEngine.Collider2D other) {
        if (other.CompareTag("Player")) {
            if (Inventory.Instance != null) {
                Inventory.Instance.AddItem(item); // Add the item to the player's inventory
                //Destroy(gameObject); // Remove the object from the scene
            }
        }
    }
}
