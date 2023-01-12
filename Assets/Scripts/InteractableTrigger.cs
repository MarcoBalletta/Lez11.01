using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTrigger : MonoBehaviour, IInteractable
{

    public InteractableItemBase itemToInteract;


    public void Interact()
    {
        itemToInteract.Interact();
    }
}

public interface IInteractable
{
    public void Interact();
}
