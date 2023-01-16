using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof(CharacterController))]
[RequireComponent (typeof(InputManager))]
[RequireComponent (typeof(ObstacleAvoidance))]
public class PlayerMovement : MonoBehaviour
{

    public float speed = 150f;
    public float rotationSpeed = 50f;
    private InputManager inputManager;
    private CharacterController character;
    public IInteractable interactableItem;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        Debug.Log(inputManager + " input");
        inputManager.actions.PlayerActions.Interact.performed += Interact;
    }

    // Update is called once per frame
    void Update()
    {
        character.SimpleMove(inputManager.ReadMovementValue() * speed * transform.forward * Time.deltaTime);
        if (!character.isGrounded) character.SimpleMove(transform.up * Physics.gravity.y * Time.deltaTime);
        //transform.Rotate(transform.up * inputManager.ReadRotationValue() * rotationSpeed * Time.deltaTime);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            interactable.Interact();
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            //can interact
            //interactable.Interact();
            UIManager.instance.CanInteract();
            interactableItem = interactable;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            //can interact
            //interactable.Interact();
            UIManager.instance.CannotInteract();
            interactableItem = null;
        }
    }

    private void Interact(InputAction.CallbackContext context)
    {
        /*
         * if(interactableItem == null) return;
         * interactableItem.Interact();
        */
        interactableItem?.Interact();
        interactableItem = null;
        UIManager.instance.CannotInteract();
    }
}
