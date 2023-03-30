using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftToRight : MonoBehaviour
{

    public bool MoveLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveLeft == true)
        {
            transform.position -= new Vector3(10, 0, 0) * Time.deltaTime;
        }
        if(MoveLeft == false)
        {
            transform.position += new Vector3(10, 0, 0) * Time.deltaTime;
        }
        if(transform.position.x <= -5)
        {
            Debug.Log("Move right");
            MoveLeft = false;
        }
        if(transform.position.x >= 5)
        {
            Debug.Log("Move left");
            MoveLeft = true;
        }
    }
}
