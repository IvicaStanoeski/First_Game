using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    float delay = 0.25f;
    float cooldownTimer = 0;
    public GameObject  BulletPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 OffsetLeft = new Vector3(-0.15f, 0, 0);
        Vector3 OffsetRight = new Vector3(0.15f, 0, 0);
        cooldownTimer -= Time.deltaTime;
        if (Input.GetKey(key: KeyCode.T) && cooldownTimer <= 0) {
            
            cooldownTimer = delay;

            Instantiate(BulletPrefab, transform.position + OffsetLeft, transform.rotation);
            Instantiate(BulletPrefab, transform.position + OffsetRight, transform.rotation);
        }

	}
}
