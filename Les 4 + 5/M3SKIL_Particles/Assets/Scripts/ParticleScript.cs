using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ParticleScript : MonoBehaviour
{
    public GameObject particle;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            particle.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            particle.SetActive(false);
        }
    }
}
