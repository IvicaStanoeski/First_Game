using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerPlayer : MonoBehaviour {
    
    public static int PlayerHealth = 3;
    

	// Use this for initialization
	void Start () {
            
    }
	
	// Update is called once per frame
	void Update () {

      

        if (PlayerHealth <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    

    void OnTriggerEnter2D()
    {
        Vector3 RespawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;

     

        if (gameObject.tag == "Player") {
            PlayerHealth--;
            transform.position = RespawnPoint;
        }
       
        
       
    }
}

