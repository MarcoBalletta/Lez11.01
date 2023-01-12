using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableItemBase : MonoBehaviour, IInteractableItem
{
    public abstract void Interact();
}

public interface IInteractableItem
{
    public void Interact();
}
