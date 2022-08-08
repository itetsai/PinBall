using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public float downSpeed;
    public float force;
    public float distance;

    float power;
    Vector3 oringinPosition;
    // Use this for initialization
    void Start()
    {
        oringinPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= oringinPosition.y && !GetComponent<Rigidbody>().isKinematic)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            power = 0;
            transform.position = oringinPosition;
        }
        else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (transform.position.y > oringinPosition.y - distance)
                    transform.Translate(0, -1 * downSpeed, 0);
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                power = oringinPosition.y - transform.position.y;
                GetComponent<Rigidbody>().isKinematic = false;
            }
            GetComponent<Rigidbody>().AddForce(transform.up * 100);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<Rigidbody>())
        {
            collision.transform.GetComponent<Rigidbody>().AddForce(power * force * Vector3.up);
            transform.GetComponent<AudioSource>().volume = ((power - distance) / distance + 0.9f)*0.1f;
            transform.GetComponent<AudioControll>().Play();
        }
    }
}
