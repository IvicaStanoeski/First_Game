using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerLasers : MonoBehaviour {

    int bulletHealth = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (bulletHealth <= 0) {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D()
    {
        bulletHealth--;
    }
}
