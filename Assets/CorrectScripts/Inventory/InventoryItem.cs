using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemObject", menuName = "ScriptableObjects" + "/Inventory" + "/CreateNewItem", order = 1)]
[System.Serializable]
public class InventoryItem : ScriptableObject
{
    public string nameOfItem;
    public uint quantity;
    public uint maxQuantity;
    public ItemCategory category;
    public float weight;
    public GameObject dropModelprefab;
    public float sellingCost;
}

public enum ItemCategory
{
    armor,
    weapon,
    consumable,
    other
}
