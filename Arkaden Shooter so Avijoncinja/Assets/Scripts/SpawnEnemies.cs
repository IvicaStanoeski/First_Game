using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnEnemies : MonoBehaviour {

    public GameObject Enemy;
    float delay = 7f;
    float cooldownTimer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            Instantiate(Enemy, transform.position, transform.rotation);
            cooldownTimer = delay;
        }

    }
}
