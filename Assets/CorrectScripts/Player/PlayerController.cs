using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public PlayerData data = new PlayerData();
    private InputManager inputManager;
    public IInteractable interactableItem;
    public InventoryComponent inventory;
    public ShootingComponent shootingComponent;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        inventory = GetComponent<InventoryComponent>();
        TryGetComponent<ShootingComponent>(out shootingComponent);
    }

    // Start is called before the first frame update
    void Start()
    {
        inputManager.actions.PlayerActions.Interact.performed += Interact;
    }

    private void Interact(InputAction.CallbackContext context)
    {
        /*
         * if(interactableItem == null) return;
         * interactableItem.Interact();
        */
        interactableItem?.Interact(this);
        interactableItem = null;
        UIManager.instance.CannotInteract();
    }

    public void PickUp(InventoryItem item)
    {
        inventory.AddItem(item);
        if(item is WeaponItem && shootingComponent.weaponSelected.WeaponModel == null)
        {
            var weaponItem = item as WeaponItem;
            shootingComponent.EquipWeapon(weaponItem.data);
        }
    }
}

[System.Serializable]
public class PlayerData
{
    public string playerName;
    public float hp;
    public float strenght;
}