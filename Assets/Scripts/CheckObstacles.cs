using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObstacles : MonoBehaviour
{

    private PlayerController playerController;
    public float rayLenght;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position + Vector3.up, transform.position + transform.forward + Vector3.up, Color.black);
        if (Physics.Raycast(transform.position + Vector3.up, transform.forward, rayLenght, layerMask, QueryTriggerInteraction.UseGlobal))
        {
            playerController.canMove = false;
        }
        else
        {
            playerController.canMove = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + transform.forward);
    }
}
