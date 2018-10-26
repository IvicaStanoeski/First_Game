using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

    float delay = 1.6f;
    float cooldownTimer = 0;
    public GameObject BulletPrefab;
    public static bool StopShoot = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LayerMask mask = LayerMask.GetMask("EnemyShootOrNot");
        RaycastHit2D ShootOrNot = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 5f, mask);
        Vector3 Offset = new Vector3(0, -0.3f, 0);
        
        cooldownTimer -= Time.deltaTime;
        if ( cooldownTimer <= 0 && StopShoot && ShootOrNot.collider == true)
        {

            cooldownTimer = delay;

            Instantiate(BulletPrefab, transform.position + Offset, transform.rotation);
            
        }

    }
}
