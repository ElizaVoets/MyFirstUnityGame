using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAndRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(1, 0, 0) * Time.deltaTime;

        if (transform.position.x <= -5)
        {
            Debug.Log("Turn around");
        }
    }
}