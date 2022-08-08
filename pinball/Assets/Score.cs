using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    public GameObject text;


    private void OnCollisionEnter(Collision collision)
    {
        int score = text.GetComponent<ScoreText>().score + 1;
        text.GetComponent<ScoreText>().score++;
        text.GetComponent<TextMeshPro>().text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        int score = text.GetComponent<ScoreText>().score + 1;
        text.GetComponent<ScoreText>().score++;
        text.GetComponent<TextMeshPro>().text = score.ToString();
    }
}
