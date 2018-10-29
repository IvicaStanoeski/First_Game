using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerLasers : MonoBehaviour {

    int bulletHealth = 1;
    public static string Missile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (bulletHealth <= 0) {
            Destroy(gameObject);
            Missile = gameObject.name;
        }
	}

    private void OnTriggerEnter2D()
    {
        bulletHealth--;
        
    }
}
