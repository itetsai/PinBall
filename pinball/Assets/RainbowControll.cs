using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowControll : MonoBehaviour {


    bool flag = true;

    float value = 0.1f;

    void Update()
    {
        if (flag)
            value += 0.01f;
        else
            value -= 0.01f;

        if (value > 2.9)
            flag = false;
        else if (value < 0.1)
            flag = true;

        GetComponent<Renderer>().material.SetFloat("_InvFade",value);
    }
}
