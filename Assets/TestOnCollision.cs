using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOnCollision : MonoBehaviour
{

    ParticleSystem psystem;
    // Start is called before the first frame update
    void Start()
    {
        psystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Do something
        Debug.Log("Collisions detected : " + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected : " + other.gameObject.name);

        if (other.CompareTag("SpawnParticles"))
        {
            psystem.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SpawnParticles"))
        {
            psystem.Stop();
        }
    }
}
