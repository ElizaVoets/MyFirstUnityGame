using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingScript : MonoBehaviour
{
        
    // Update is called once per frame
    void Update()
    { 

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += (Vector3.up * 20) * Time.deltaTime;
        }
    }
}
