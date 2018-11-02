using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(key: KeyCode.Space)) {

            SceneManager.LoadScene("GameScene");
            
        }

        if (Input.GetKeyDown(key: KeyCode.Escape))
        {

            Application.Quit();
        }
    }
}
