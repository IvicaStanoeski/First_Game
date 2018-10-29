using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAndMoveTowardsPlayer : MonoBehaviour {

    Transform Player;
    float rotSpeed = 120f;
    float acceleration = 0.9f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, -acceleration * Time.deltaTime, 0);

        pos += transform.rotation * velocity;

        

        GameObject PlayerShip = GameObject.Find("PlayerShip");
        Player = PlayerShip.transform;

        Vector3 direction = Player.position - transform.position;
        direction.Normalize();
        float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90;
        Quaternion desiredRot = Quaternion.Euler(0,0,zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);


        if (gameObject.name == SpecialSelfDestruct.Missile) {
            if (SpecialSelfDestruct.StopMove == false) {
                transform.position = pos;
            }
        }

        if (gameObject.name != SpecialSelfDestruct.Missile) {
            transform.position = pos;
        }
    }

   

}
