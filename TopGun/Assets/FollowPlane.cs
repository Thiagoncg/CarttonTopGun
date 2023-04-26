using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlane : MonoBehaviour
{
    public Transform target; // game object lookat
    [SerializeField] private Vector3 offset;    
    [SerializeField] private float translateSpeed; // distance and velocity translate the object
    [SerializeField] private float rotationSpeed; // distance and rotation velocity the object
    
    private void Update()
    {
        HandleTranslation();
        HandleRotation();
    }

    private void HandleTranslation()
    {
        var targetPosition = target.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetPosition, translateSpeed * Time.deltaTime);
    }

    private void HandleRotation()
    {
        var direction = target.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }



























    // public Transform looKat;
    // private Vector3 desiredPosition;
    // public float offseat = 1.5f;
    // public float distance = 3.5f;
    // // Update is called once per frame
    // void Update()
    // {
    //     //Start Updater position camera
    //     desiredPosition = looKat.position + (-transform.forward * distance) + (transform.up * offseat);
    //     transform.position = Vector3.Lerp(transform.position, desiredPosition, 0.05f);


    //     //Started Updater Rotation camera position
    //     transform.LookAt(looKat.position + (Vector3.up * offseat));
    // }
}
