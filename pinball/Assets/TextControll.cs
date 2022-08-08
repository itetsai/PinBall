using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextControll : MonoBehaviour {


    bool flag = true;

    float value = 0.1f;

    void Update()
    {
        if (flag)
            value += 0.005f;
        else
            value -= 0.005f;

        if (value > 0.9)
            flag = false;
        else if (value <0.05)
            flag = true;

        GetComponent<Renderer>().material.SetFloat("_GlowPower", value);
    }
}
