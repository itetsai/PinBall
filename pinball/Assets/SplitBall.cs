using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    float time = 100;
    bool flag = false;
    bool flag2;
    public float power;
    public GameObject ball;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time < 4.5)
        {
            ball.transform.position = transform.position;
            ball.GetComponent<Rigidbody>().isKinematic = true;
            flag = true;
        }
        else if (time > 4.5 && time < 5)
        {
            if (flag)
            {
                flag = false;
                GameObject fakeball = Instantiate(ball);
                fakeball.GetComponent<Rigidbody>().isKinematic = false;

                ball.GetComponent<Rigidbody>().isKinematic = false;
                float direction = Random.Range(0, 3.2f);
                ball.GetComponent<Rigidbody>().AddForce(power * new Vector3(Mathf.Sin(direction), Mathf.Cos(direction), 0));

                float direction2 = Random.Range(0, 3.2f);
                fakeball.GetComponent<Rigidbody>().AddForce(power * new Vector3(Mathf.Sin(direction2), Mathf.Cos(direction2), 0));
            }
        }
        else
            flag2 = true;

    }

    
    private void OnTriggerStay(Collider other)
    {
        if (flag2&& other.gameObject==ball)
        {
            time = 0;
            flag2 = false;
            transform.GetComponent<AudioControll>().Play();
        }
    }
}
