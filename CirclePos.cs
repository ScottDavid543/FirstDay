﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CirclePos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, -0.2f, transform.position.z);
	}
}
