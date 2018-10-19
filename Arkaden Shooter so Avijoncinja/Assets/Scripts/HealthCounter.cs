using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour {

   public Text name_text;
    

	// Use this for initialization
	void Start () {
        name_text.text = "Health:  " + DamageHandlerPlayer.PlayerHealth;
	}
	
	// Update is called once per frame
	void Update () {
        name_text.text = "health:  " + DamageHandlerPlayer.PlayerHealth;
    }
}
