using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyShipMove : MonoBehaviour {

    float speed = 0.2f;
    int TimeLeft = 7;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DamageHandlerEnemy.StopMove)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        TimeLeft--;
        Vector3 randomPoint = new Vector3(Random.Range(-20000f, 20000f), Random.Range(-15500f, 13500f));
        if (randomPoint.x > 0)
        {
            randomPoint.x += 25000f;
        }
        else {
            randomPoint.x -= 25000f;
        }
        Vector3 newRandomPoint = randomPoint;
        
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.03f, 0.97f);
       // pos.y = Mathf.Clamp(pos.y, 0.36f, 0.94f);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        if ((TimeLeft <= 0) && DamageHandlerEnemy.StopMove)
        {
           
            Vector3 currentPosition = gameObject.transform.position;
            transform.position = Vector3.Lerp(currentPosition, newRandomPoint, Time.deltaTime * 0.0002f);
            TimeLeft = 7;
        }
	}
}
