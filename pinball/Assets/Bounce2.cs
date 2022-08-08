using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce2 : MonoBehaviour
{
    public float force;
    float time = 10;

    float up = 1;

    Vector3 oringinalPosition;
    private void Start()
    {
        oringinalPosition = transform.position;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time < 0.1)
            transform.Translate(0, Time.deltaTime * 10, 0);
        else if (time > 0.1 && time < 4)
            ;
        else if (time > 4 && time < 5)
            transform.Translate(0, -1 * Time.deltaTime, 0);
        else
            transform.position = oringinalPosition;

    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.GetComponent<AudioControll>().Play();
        if (collision.transform.GetComponent<Rigidbody>())
        {
            collision.transform.position = new Vector3(oringinalPosition.x, oringinalPosition.y + 2, collision.transform.position.z);
            collision.transform.GetComponent<Rigidbody>().AddForce(force * Vector3.up);
            time = 0;
        }
    }
}
