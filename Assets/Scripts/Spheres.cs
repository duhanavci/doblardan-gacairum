using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    private Rigidbody  myBody;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        

    }
    private void FixedUpdate()
    {
        myBody.velocity = new Vector3(speed, myBody.velocity.y, myBody.velocity.z);
    }

}
