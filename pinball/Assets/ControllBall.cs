using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllBall : MonoBehaviour
{
    public GameObject ball;
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && Input.GetKey(KeyCode.F1))
        {
            ball.transform.GetComponent<Rigidbody>().isKinematic = true;

            ball.transform.position = new Vector3(hit.point.x, hit.point.y, ball.transform.position.z);
            Debug.DrawLine(Camera.main.transform.position, hit.point);
            Debug.Log(hit.transform.name);
        }
        else
            ball.transform.GetComponent<Rigidbody>().isKinematic = false;
    }
}