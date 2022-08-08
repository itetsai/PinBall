using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControll : MonoBehaviour {


    float value = 0;
    private void Update()
    {
        if (value < 1)
        {
            value += 0.05f;
            GetComponent<Renderer>().material.SetFloat("_Cutoff", value);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        value = 0;
    }
}
