using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    float speed = 0.2f;
    float counter = 0f;
    float limit = 1000000f;
   
    // Use this for initialization
    void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        if (counter < limit)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            counter++;
        }
       

    }
}
