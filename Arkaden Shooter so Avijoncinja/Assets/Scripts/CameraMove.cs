using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    float speed = 0.2f;
    float counter = 0f;
    float limit = 7600f;
    bool Pause = false;
    AudioSource audioSource; 
   
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (counter < limit)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            counter++;
            
        }

        if (Input.GetKeyDown(key: KeyCode.Space)) {
            if (Pause == false) {
                Pause = true;
                Time.timeScale = 0;
                audioSource.Pause();
            }
            else  {
                Pause = false;
                Time.timeScale = 1;
                audioSource.Play();
            }

        }
    }
}
