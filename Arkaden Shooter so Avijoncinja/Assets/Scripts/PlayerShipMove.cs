using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMove : MonoBehaviour {

    float speed = 0.2f;
    float counter = 0f;
    float limit = 7600f;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        {
        if (DamageHandlerPlayer.RemoveClamp == false) {
            Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
            pos.x = Mathf.Clamp(pos.x, 0.03f, 0.97f);
            pos.y = Mathf.Clamp(pos.y, 0.06f, 0.94f);
            transform.position = Camera.main.ViewportToWorldPoint(pos);
        }
        if ((counter < limit) && DamageHandlerPlayer.StopMove)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                counter++;
            }
            if (Input.GetKey(key: KeyCode.W) && DamageHandlerPlayer.StopMove)
            {
                transform.Translate(Vector3.up * (speed + 3f) * Time.deltaTime);
            }
            if (Input.GetKey(key: KeyCode.S) && DamageHandlerPlayer.StopMove)
            {
                transform.Translate(Vector3.down * (speed + 3f) * Time.deltaTime);
            }
            if (Input.GetKey(key: KeyCode.A) && DamageHandlerPlayer.StopMove)
            {
                transform.Translate(Vector3.left * (speed + 3f) * Time.deltaTime);
            }
            if (Input.GetKey(key: KeyCode.D) && DamageHandlerPlayer.StopMove)
            {
                transform.Translate(Vector3.right * (speed + 3f) * Time.deltaTime);
            }
            
            
        }
    
}
