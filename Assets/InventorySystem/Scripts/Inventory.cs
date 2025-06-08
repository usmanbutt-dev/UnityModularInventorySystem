using System.Collections;
using System.Collections.Generic;
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
        items.Add(item);
        GameObject newItem = Instantiate(itemUIPrefab, itemSpawnParent);
        newItem.transform.GetChild(0).GetComponent<Image>().sprite = item.icon;
        newItem.GetComponent<ItemUI>().item = item;
        Debug.Log("Picked up: " + item.itemName);
    }

    public void ToggleInventory() {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
