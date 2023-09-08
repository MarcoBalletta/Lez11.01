using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public InputActions actions;

    // Start is called before the first frame update
    void Awake()
    {
        actions = new InputActions();
        actions.Enable();
    }

    public void CanMove()
    {
        actions.PlayerActions.Movement.Enable();
    }

    public void CannotMove()
    {
        actions.PlayerActions.Movement.Disable();
    }

    public float ReadMovementValue()
    {
        return actions.PlayerActions.Movement.ReadValue<float>();
    }

    public void CanRotate()
    {
        actions.PlayerActions.Rotation.Enable();
    }

    public void CannotRotate()
    {
        actions.PlayerActions.Rotation.Disable();
    }

    public void CanShoot()
    {
        actions.PlayerActions.Shoot.Enable();
    }

    public void CannotShoot()
    {
        actions.PlayerActions.Shoot.Disable();
    }

    public float ReadRotationValue()
    {
        return actions.PlayerActions.Rotation.ReadValue<float>();
    }
}
