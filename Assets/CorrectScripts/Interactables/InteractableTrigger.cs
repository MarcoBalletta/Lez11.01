using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTrigger : InteractableBase
{

    public InteractableItemBase itemToInteract;

    public override void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            UIManager.instance.SetInteractText(constants.textInteractInteractable);
            UIManager.instance.CanInteract(gameObject.ToString());

        }
        base.OnTriggerEnter(other);
    }

    public override void Interact(PlayerController player)
    {
        itemToInteract.InteractItem();
    }
}


