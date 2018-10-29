using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootUnderAngle : MonoBehaviour {

    float delay = 3f;
    float cooldownTimer = 0;
    bool StartShooting = false;
    public GameObject BulletPrefab;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        LayerMask mask = LayerMask.GetMask("EnemyShootOrNot");
        RaycastHit2D ShootOrNot = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 5.5f, mask);

        cooldownTimer -= Time.deltaTime;

        if (ShootOrNot.collider == true) {

            StartShooting = true;
        }

        if (cooldownTimer <= 0 && StartShooting)
        {

            cooldownTimer = delay;

            Instantiate(BulletPrefab, transform.position, transform.rotation);
            

        }
    }
}
