﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 18;

    private Rigidbody rig;

	// Use this for initialization
	void Start () 
    {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(hAxis * speed * Time.deltaTime, 0, vAxis* speed * Time.deltaTime) ;

		transform.Translate(movement);
	}
}
