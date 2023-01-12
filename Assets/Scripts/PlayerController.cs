using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Stats")]
    public float speed;
    public float rotationSpeed;
    public bool canMove;
    private InputActions input;

    //components
    private CharacterController characterController;
    private float movementForce;
    public float rayLenght;
    public LayerMask layerMask;

    void Start()
    {
        input = new InputActions();
        input.Enable();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {

        //rotation
        transform.Rotate(new Vector3(0, input.PlayerActions.Rotation.ReadValue<float>(), 0) * Time.deltaTime * rotationSpeed);
    }

    private void FixedUpdate()
    {
        //movement

        movementForce = input.PlayerActions.Movement.ReadValue<float>();
        if (!characterController.isGrounded) characterController.SimpleMove(transform.up * Physics.gravity.y * Time.deltaTime);
        if (canMove) characterController.SimpleMove(transform.forward * movementForce * speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            interactable.Interact();
        }
    }
}
