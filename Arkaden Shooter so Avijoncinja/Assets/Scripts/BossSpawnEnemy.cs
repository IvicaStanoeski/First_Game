using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnEnemy : MonoBehaviour {


    public GameObject Enemy;
    float delay = 7f;
    float cooldownTimer = 0;
    public Sprite[] EnemySprites;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LayerMask mask = LayerMask.GetMask("EnemyShootOrNot");
        RaycastHit2D SpawnOrNot = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 5.5f, mask);

        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer <= 0 && SpawnOrNot.collider)
        {
            GameObject Clone;
            Clone = Instantiate(Enemy, transform.position, transform.rotation);
            int i = Random.Range(0, EnemySprites.Length);
            Clone.GetComponent<SpriteRenderer>().sprite = EnemySprites[i];
            int x = Random.Range(0, 1000);
            Clone.name = "SmallEnemy" + x;
            cooldownTimer = delay;
        }

    }
}
