using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRandomMove : MonoBehaviour {

    float speed = 0.2f;
    int TimeLeft = 0;
    Vector3 EndPoint;
    Vector3 velocity = Vector3.zero;
    // Use this for initialization
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
         EndPoint = GameObject.FindGameObjectWithTag("EndPoint").transform.position;
        
        if (gameObject.name == DamageHandlerEnemy.EnemyName)
        {
            if (DamageHandlerEnemy.StopMove)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            TimeLeft--;
            Vector3 randomPoint = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            if (randomPoint.x > 0)
            {
                randomPoint.x += 14f;
            }
            if(randomPoint.x < 0)
            {
                randomPoint.x -= 14f;
            }
            if (randomPoint.y > 0)
            {
                randomPoint.y += 2f;
            }
            if(randomPoint.y < 0)
            {
                randomPoint.y -= 2f;
            }
            Vector3 newRandomPoint = randomPoint;

            Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
            pos.x = Mathf.Clamp(pos.x, 0.03f, 0.97f);
            // pos.y = Mathf.Clamp(pos.y, 0.36f, 0.94f);
            transform.position = Camera.main.ViewportToWorldPoint(pos);
            if ((TimeLeft <= 0) && DamageHandlerEnemy.StopMove)
            {

                Vector3 currentPosition = gameObject.transform.position;
                transform.position = Vector3.SmoothDamp(currentPosition, newRandomPoint, ref velocity, 1.2f);
                TimeLeft = 0;
            }
        }

        if (gameObject.name != DamageHandlerEnemy.EnemyName) {
            transform.Translate(Vector3.up * speed * Time.deltaTime);

            TimeLeft--;
            Vector3 randomPoint = new Vector3(Random.Range(-1f, 1f), Random.Range(0f, 0f));
            if (randomPoint.x > 0)
            {
                randomPoint.x += 80f;
            }
            else
            {
                randomPoint.x += -80f;
            }
           
          
            Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
            pos.x = Mathf.Clamp(pos.x, 0.03f, 0.97f);
            // pos.y = Mathf.Clamp(pos.y, 0.36f, 0.94f);
            transform.position = Camera.main.ViewportToWorldPoint(pos);
            if (TimeLeft <= 0)
            {
                Vector3 newRandomPoint = randomPoint;
                Vector3 Yoffset = new Vector3(0, -1f, 0);
                EndPoint.x += randomPoint.x;
                EndPoint.y += Yoffset.y;

                Vector3 currentPosition = gameObject.transform.position;
                transform.position = Vector3.SmoothDamp(currentPosition, EndPoint, ref velocity, 4.5f);
                TimeLeft = 0;


            }
        }
        
    }
}
