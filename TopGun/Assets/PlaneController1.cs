using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController1 : MonoBehaviour
{

    PowerApp powerApp = new PowerApp();
    private float horizontalInput;
    private float verticalInput;
    private float speed = 0.3f;
    void Update()
    {
        ControllerPlaneDirection();
    }

    private void ControllerPlaneDirection()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, -horizontalInput * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(verticalInput * speed, 0, 0);

        transform.position += transform.forward * speed / 20;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerAp"))
        {
            speed = 1f;
        }
    }

}
