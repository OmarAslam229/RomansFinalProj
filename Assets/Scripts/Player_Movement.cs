using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public float speed, turnSpeed;

    Rigidbody rigidbody;

    // Use this for initialization
    void Start () {

        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

       // if(inpu)
		
	}

    void  FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        { //Spacebar by default will make it move forward 
            rigidbody.AddRelativeForce (Vector3.forward*speed); }
        rigidbody.AddRelativeTorque ((Input.GetAxis("Vertical"))*turnSpeed,0,0);
        // W key or the up arrow to turn upwards, S or the down arrow to turn downwards. 
        rigidbody.AddRelativeTorque (0,(Input.GetAxis("Horizontal"))*turnSpeed,0); // A or left arrow to turn left, D or right arrow to turn right. 
    } 
        }
