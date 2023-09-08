using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public float lateralSpeed;
    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<CharacterController>(out controller))
        {
            Debug.Log("Non hai un character controller");
        }
        //controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //controller.SimpleMove((transform.forward * speed * Input.GetAxis(Constants.AXIS_VERTICAL)) + (transform.right * lateralSpeed * Time.deltaTime * Input.GetAxis(Constants.AXIS_HORIZONTAL)) * Time.deltaTime);
        Vector3 movement = Vector3.zero;
        movement = transform.forward * speed * Time.deltaTime * Input.GetAxis(Constants.AXIS_VERTICAL);
        //movement += transform.right * lateralSpeed * Time.deltaTime * Input.GetAxis(Constants.AXIS_HORIZONTAL);
        //controller.SimpleMove(transform.forward * speed * Time.deltaTime * Input.GetAxis(Constants.AXIS_VERTICAL));
        //controller.SimpleMove(transform.right * lateralSpeed * Time.deltaTime * Input.GetAxis(Constants.AXIS_HORIZONTAL));
        transform.Rotate(lateralSpeed * Time.deltaTime * transform.up * Input.GetAxis(Constants.AXIS_HORIZONTAL));
        controller.SimpleMove(movement);
    }
}
