using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBound : MonoBehaviour
{
    



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xpos = Mathf.Clamp(transform.position.x, -10.0f, 10.0f);
        transform.position = new Vector3(xpos,transform.position.y, transform.position.z);

    }
}
