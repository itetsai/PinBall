using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningControll : MonoBehaviour {


    float time=0;
    GameObject ball=null;
    private void Update()
    {
        time += Time.deltaTime;
        if (ball)
        {
            if (time >= 0.5)
            {
                ball.GetComponent<TrailRenderer>().enabled = false;
                ball = null;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ball = other.gameObject;
        other.GetComponent<TrailRenderer>().enabled = true;
        time = 0;
    }
}
