using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

    public Text ScoreText; 

	// Use this for initialization
	void Start () {

        ScoreText.text = ("You're final score: " + ScoreBoard.Score);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
