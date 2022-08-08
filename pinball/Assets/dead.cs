using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour {

    public Vector3 restartPosition;
    public GameObject ball;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
            other.transform.position = restartPosition;
        else
            Destroy(other.gameObject);
        GetComponent<AudioControll>().Play();
    }
}
