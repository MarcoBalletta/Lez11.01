using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(CharacterController))]
[RequireComponent (typeof(InputManager))]
[RequireComponent (typeof(ObstacleAvoidance))]
public class PlayerMovement : MonoBehaviour
{

    public float speed = 150f;
    public float rotationSpeed = 50f;
    private InputManager inputManager;
    private CharacterController character;

    // Start is called before the first frame update
    void Start()
    {
        inputManager = GetComponent<InputManager>();
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        character.SimpleMove(inputManager.ReadMovementValue() * speed * transform.forward * Time.deltaTime);
        if (!character.isGrounded) character.SimpleMove(transform.up * Physics.gravity.y * Time.deltaTime);
        //transform.Rotate(transform.up * inputManager.ReadRotationValue() * rotationSpeed * Time.deltaTime);
    }
}
