using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObjects : MonoBehaviour
{
    [SerializeField] GameObject target;



    private void Update()
    {
        //transform.rotation = Quaternion.LookRotation(transform.position - _object.transform.rotation);
        transform.LookAt(transform.position + target.transform.rotation * Vector3.forward, target.transform.rotation * Vector3.up);
    }

}
