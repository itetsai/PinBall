using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float power;
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 oringinal = collision.transform.position;
        collision.transform.GetComponent<Rigidbody>().AddForce((oringinal - transform.position) * power);
        GetComponent<AudioControll>().Play();
    }
}
