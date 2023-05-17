using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerApp : MonoBehaviour
{
    public float power;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plane"))
        {
           Debug.Log("Triguer com Tag");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collidiu");
    }
}
