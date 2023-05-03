using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomnInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefap;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Disparar uma bomba e expodir tudo");
            GameObject newBomb = Instantiate(bombPrefap, transform.position, transform.rotation);
            Rigidbody rb = newBomb .GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 1000f);
         }
    }
}
