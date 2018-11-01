using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerEnemy : MonoBehaviour {
    
    public int EnemyHealth = 5;
    public GameObject Explosion;
    public GameObject Explosion1;
    public GameObject Explosion2;
    bool RunOnce = true;
    public static string EnemyName;
    public static bool StopMove = true;
    public int ScoreEncrease;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

        if (EnemyHealth <= 0)
        {
            EnemyName = gameObject.name;
            
            EnemyShooting.StopShoot = false;
            if (RunOnce)
            {
                StartCoroutine(Explode());
                ScoreBoard.Score += ScoreEncrease;
            }
               RunOnce = false;
        }

       

    }



    void OnTriggerEnter2D()
    {
        EnemyHealth--;
        
    }

    private IEnumerator Explode()
    {
        StopMove = false;
        
        //Vector3 offset1 = new Vector3(0.2f, 0.15f, 0);
       // Vector3 offset2 = new Vector3(-0.1f, -0.2f, 0);
        GameObject CloneExplosion = Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(CloneExplosion, 1.8f);
        yield return new WaitForSeconds(0.5f);
       // GameObject CloneExplosion1 = Instantiate(Explosion1, transform.position + offset1, transform.rotation);
      //  Destroy(CloneExplosion1, 1.3f);
       // yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
      //  GameObject CloneExplosion2 = Instantiate(Explosion2, transform.position + offset2, transform.rotation);
       // Destroy(CloneExplosion2, 0.8f);
        StopMove = true;
        EnemyShooting.StopShoot = true;
    }

    
}
