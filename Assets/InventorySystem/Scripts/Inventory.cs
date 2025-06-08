using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour {
    public static Inventory Instance {get; private set; }
    public List<Item> items = new List<Item>();
    public GameObject itemUIPrefab;
    Transform itemSpawnParent; // 0->0->1

    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start() {
        this.gameObject.SetActive(false);
        itemSpawnParent = transform.GetChild(0).GetChild(0).GetChild(1); // 0->0->1
    }

    public void AddItem(Item item) {
        // Check if the item is stackable
        if (item.isStackable) {
            // Search for existing UI instance of this item
            foreach (Transform child in itemSpawnParent) {
                ItemUI itemUI = child.GetComponent<ItemUI>();
                if (itemUI != null && itemUI.item == item) {
                    // Found matching item UI
                    TMP_Text countText = child.GetChild(1).GetComponent<TMP_Text>();
                    int currentCount = int.Parse(countText.text);

                    if (currentCount < item.maxStack) {
                        currentCount++;
                        countText.text = currentCount.ToString();
                        Debug.Log("Stacked item: " + item.itemName + " (x" + currentCount + ")");
                    }
                    else {
                        Debug.Log("Cannot stack " + item.itemName + ". Max stack of " + item.maxStack + " reached.");
                    }

                    return; // Item handled
                }
            }
        }

        // If not stackable or no existing stack found
        items.Add(item);
        GameObject newItem = Instantiate(itemUIPrefab, itemSpawnParent);

        // Set icon on first child (icon Image)
        newItem.transform.GetChild(0).GetComponent<Image>().sprite = item.icon;

        // Set stack count if stackable
        if (item.isStackable) {
            TMP_Text countText = newItem.transform.GetChild(1).GetComponent<TMP_Text>();
            countText.text = "1";
        }

        // Assign item data
        ItemUI itemUIComponent = newItem.GetComponent<ItemUI>();
        itemUIComponent.item = item;
        Destroy(item.GameObject());
        Debug.Log("Picked up: " + item.itemName);
    }


    public void ToggleInventory() {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
