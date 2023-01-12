using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAvoidance : MonoBehaviour
{

    private InputManager inputManager;
    public float rayLength = 2;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        inputManager = GetComponent<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, rayLength, layerMask, QueryTriggerInteraction.Collide))
        {
            if (inputManager.actions.PlayerActions.Movement.enabled) inputManager.CannotMove();
        }
        else
        {
            if (!inputManager.actions.PlayerActions.Movement.enabled) inputManager.CanMove();
        }
    }
}
