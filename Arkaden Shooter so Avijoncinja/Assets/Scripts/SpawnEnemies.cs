using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnEnemies : MonoBehaviour {

    public GameObject Enemy;
    float delay = 7f;
    float cooldownTimer = 0;
    public Sprite[] EnemySprites;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0)
        {
            GameObject Clone;
            Clone = Instantiate(Enemy, transform.position, transform.rotation);
            int i = Random.Range(0,EnemySprites.Length);
            Clone.GetComponent<SpriteRenderer>().sprite = EnemySprites[i];
            cooldownTimer = delay;
        }

    }
}
