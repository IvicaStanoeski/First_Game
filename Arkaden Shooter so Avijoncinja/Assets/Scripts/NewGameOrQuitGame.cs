using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGameOrQuitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(key: KeyCode.Space)) {

            DamageHandlerPlayer.PlayerHealth = 3;
            ScoreBoard.Score = 300;
            DamageHandlerPlayer.StopMove = true;
            DamageHandlerPlayer.RemoveClamp = false;
            Shooting.StopShoot = true;
            SceneManager.LoadScene("GameScene");
        }

        if (Input.GetKeyDown(key: KeyCode.Escape)) {

            Application.Quit();
        }
	}
}
