using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    public Text ScoreText;
    public static int Score = 300;

	// Use this for initialization
	void Start () {

        ScoreText.text = "Score:  " + Score;
	}
	
	// Update is called once per frame
	void Update () {

        ScoreText.text = "Score:  " + Score;
    }
}
