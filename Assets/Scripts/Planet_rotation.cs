using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_rotation : MonoBehaviour {

     Vector3 rand_values;

    Rigidbody rb;


	// Use this for initialization
	void Start () {
        
        //rand_values = 

        rb = GetComponent<Rigidbody>();
        rb.AddTorque(new Vector3(Random.Range(-5,5), Random.Range(-5, 5), Random.Range(-5, 5)));
    }
	
	// Update is called once per frame
	void Update () {

        
		
	}
}
