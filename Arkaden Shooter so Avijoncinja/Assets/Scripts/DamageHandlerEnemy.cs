using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerEnemy : MonoBehaviour {
    
    int EnemyHealth = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }

       

    }



    void OnTriggerEnter2D()
    {
        
            EnemyHealth--;
        


    }
}
