using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour {


    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.GetComponentInChildren<ParticleSystem>().Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        other.transform.GetComponentInChildren<ParticleSystem>().Play();
    }
}
