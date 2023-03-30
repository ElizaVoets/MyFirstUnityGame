using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class getPickUp : MonoBehaviour
{
    private Renderer r;
    private AudioSource source;
    private ParticleSystem ps;

    private keepScore scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();

        scoreScript = FindObjectOfType<keepScore>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            r.enabled = false;
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 3.5f);
            source.Play();
            ps.Play();

            scoreScript.AddScore(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
