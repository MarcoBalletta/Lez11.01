using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryComponent : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> inventory = new List<InventoryItem>();

    public float GetStrength()
    {
        if (TryGetComponent<PlayerController>(out PlayerController controller))
        {
            return controller.data.strenght;
        }
        else return 0;
    }

    public float GetTotalItemsWeight()
    {
        float sum = 0;
        foreach(var item in inventory)
        {
            sum += item.weight;
        }
        return sum;
    }

    public bool CanAddItem(InventoryItem item)
    {
        if (GetStrength() >= GetTotalItemsWeight() + item.weight) return true;
        else return false;
    }

    public void AddItem(InventoryItem item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(InventoryItem item)
    {
        inventory.Remove(item);
    }
}
