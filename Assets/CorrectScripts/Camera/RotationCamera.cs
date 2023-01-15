using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCamera : MonoBehaviour
{

    public InputManager playerActions;
    public Transform rotationArm;
    private Vector2 previousPosition = Vector2.zero;
    public float rotationSpeedX;
    public float rotationSpeedY;
    public float lerpRotation;
    public float maxYAngle;

    // Update is called once per frame
    void FixedUpdate()
    {
        //var direction = previousPosition - playerActions.actions.Camera.CameraRotation.ReadValue<Vector2>();
        float currentRotationX = rotationSpeedX * playerActions.actions.Camera.CameraRotation.ReadValue<Vector2>().x;
        float currentRotationY = rotationSpeedY * -playerActions.actions.Camera.CameraRotation.ReadValue<Vector2>().y;
        currentRotationX = Mathf.Repeat(currentRotationX, 360);
        currentRotationY = Mathf.Clamp(currentRotationY, -maxYAngle, maxYAngle);
        //transform.rotation = Quaternion.Euler(currentRotationY, currentRotationX, 0);
        playerActions.transform.rotation = Quaternion.Lerp(playerActions.transform.rotation, Quaternion.Euler(currentRotationY, currentRotationX, 0), lerpRotation);
        
        //transform.Rotate(currentRotationX, currentRotationY, 0);

    }

    private void LateUpdate()
    {
        transform.LookAt(rotationArm);
    }
}
