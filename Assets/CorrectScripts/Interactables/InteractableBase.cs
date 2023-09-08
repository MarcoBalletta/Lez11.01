using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Collider))]
public abstract class InteractableBase : MonoBehaviour, IInteractable
{
    public abstract void Interact(PlayerController player);
    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            player.interactableItem = this;
        }
    }

    public virtual void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            UIManager.instance.CannotInteract();
            player.interactableItem = null;
        }
    }
}

public interface IInteractable
{
    public void Interact(PlayerController player);
}