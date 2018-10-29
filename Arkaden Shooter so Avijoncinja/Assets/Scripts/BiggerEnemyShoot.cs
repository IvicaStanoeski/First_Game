using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggerEnemyShoot : MonoBehaviour {


    float delay = 3f;
    float cooldownTimer = 0;
    float delaymissile = 4f;
    float cooldownTimerMissile = 4;
    public GameObject BulletPrefab;
    public GameObject MissilePrefab;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        LayerMask mask = LayerMask.GetMask("EnemyShootOrNot");
        RaycastHit2D ShootOrNot = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 5.5f, mask);

        Vector3 OffsetLeft = new Vector3(-0.17f, -0.13f, 0);
        Vector3 OffsetRight = new Vector3(0.17f, -0.13f, 0);
        Vector3 OffsetMissile = new Vector3(0, -0.41f, 0);
        cooldownTimer -= Time.deltaTime;
        cooldownTimerMissile -= Time.deltaTime;

        if (ShootOrNot.collider == true) {
            if (cooldownTimer <= 0) {

                cooldownTimer = delay;

                Instantiate(BulletPrefab, transform.position + OffsetLeft, transform.rotation);
                Instantiate(BulletPrefab, transform.position + OffsetRight, transform.rotation);

            }

            if (cooldownTimerMissile <= 0)
            {

                cooldownTimerMissile = delaymissile;

                GameObject clone = Instantiate(MissilePrefab, transform.position + OffsetMissile, transform.rotation);
                int i = Random.Range(0,1000);
                clone.name = "Missle" + i;


            }

        }
     }
}
