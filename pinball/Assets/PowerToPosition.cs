using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerToPosition : MonoBehaviour {

    public float power;

    private void OnTriggerStay(Collider other)
    {
        Vector3 oringinal = other.transform.position;
        other.transform.GetComponent<Rigidbody>().AddForce((oringinal - transform.position) * power);
    }
}
