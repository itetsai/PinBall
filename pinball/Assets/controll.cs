using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public KeyCode controllKey;

    bool press = false;
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(controllKey))
        {
            if (!press)
            {
                GetComponent<AudioControll>().playTime=0.2f;
                GetComponent<AudioControll>().startTime = 0.1f;
                GetComponent<AudioControll>().Play();
            }
            JointMotor motor = new JointMotor();
            motor.force = 1000;
            motor.targetVelocity = 100000;
            GetComponent<HingeJoint>().motor = motor;
            press = true;
        }
        else
        {
            if (press)
            {
                GetComponent<AudioControll>().playTime = 0.18f;
                GetComponent<AudioControll>().startTime = 0.3f;
                GetComponent<AudioControll>().Play();
            }
            JointMotor motor = new JointMotor();
            motor.force = 1000;
            motor.targetVelocity = -100000;
            GetComponent<HingeJoint>().motor = motor;
            press = false;
        }
        
	}
}
