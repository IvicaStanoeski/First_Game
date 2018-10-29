﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBulletMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, -2f * Time.deltaTime, 0);

        pos += transform.rotation * velocity;

        transform.position = pos;
    }
}
