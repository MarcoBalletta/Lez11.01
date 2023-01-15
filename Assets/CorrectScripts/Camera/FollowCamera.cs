using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    public Transform player;
    public float lerpVelocity;
    public float armLength;

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.LookAt(player);
        transform.position = Vector3.Lerp(transform.position, player.position + (player.transform.forward*-1 * armLength), lerpVelocity);
    }
}
