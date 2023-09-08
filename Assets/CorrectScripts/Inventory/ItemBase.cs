using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : InteractableBase
{
    public InventoryItem itemData;

    public override void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            UIManager.instance.SetInteractText(constants.textInteractItem);
            UIManager.instance.CanInteract(itemData.name);
        }
        base.OnTriggerEnter(other);
    }

    public override void Interact(PlayerController player)
    {
        player.PickUp(itemData);
        Destroy(this.gameObject, 0.1f);
    }
}
