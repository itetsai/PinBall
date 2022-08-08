using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControll : MonoBehaviour
{

    public float playTime;
    public float startTime;
    float time=1000;

    public void Play()
    {
        transform.GetComponent<AudioSource>().time= startTime;
        transform.GetComponent<AudioSource>().Play();
        time = 0;
    }

    private void Update()
    {
        if (time > playTime)
                transform.GetComponent<AudioSource>().Stop();

        time += Time.deltaTime;
    }
}
