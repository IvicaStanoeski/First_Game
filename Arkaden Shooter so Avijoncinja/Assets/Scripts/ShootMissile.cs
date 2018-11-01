using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMissile : MonoBehaviour {

    public GameObject MissilePrefab;
    float cooldownTimerMissile = 9f;
    float delaymissile = 9f;
    public float test;
    float ofset = 0.008f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        LayerMask mask = LayerMask.GetMask("EnemyShootOrNot");
        RaycastHit2D ShootOrNot = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 5.5f, mask);

        cooldownTimerMissile -= Time.deltaTime;
        
     

        if (cooldownTimerMissile < test+ofset && cooldownTimerMissile > test-ofset && ShootOrNot.collider)
        {

            GameObject clone = Instantiate(MissilePrefab, transform.position, transform.rotation);
            int i = Random.Range(0, 1000);
            clone.name = "Missle" + i;
           
        }

        if (cooldownTimerMissile <=0) {

           cooldownTimerMissile = delaymissile;
            
        }
       
        
    }
}
