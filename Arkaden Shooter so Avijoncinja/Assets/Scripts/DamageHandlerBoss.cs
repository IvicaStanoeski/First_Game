using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandlerBoss : MonoBehaviour {

    public int EnemyHealth = 100;
    public GameObject Explosion;
    public GameObject Explosion1;
    public GameObject Explosion2;
    public GameObject Explosion3;
    bool RunOnce = true;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
        gameObject.layer = 10;
        LayerMask mask = LayerMask.GetMask("EnemyShootOrNot");
        RaycastHit2D Invulrneable = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 8f, mask);
        if (Invulrneable)
        {

            gameObject.layer = 9;
        }
        
        if (EnemyHealth <= 0)
        {
            EnemyShooting.StopShoot = false;
            if (RunOnce)
            {
                StartCoroutine(Explode());
                ScoreBoard.Score += 1000;
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
        

        Vector3 offset1 = new Vector3(0f, -2.8f, 0);
        Vector3 offset2 = new Vector3(2.6f, -1.6f, 0);
        Vector3 offset3 = new Vector3(-2.6f, -1.6f, 0);
        Vector3 offset4 = new Vector3(0f, -0.5f, 0);
        GameObject CloneExplosion = Instantiate(Explosion, transform.position + offset1, transform.rotation);
        Destroy(CloneExplosion, 2.5f);
        yield return new WaitForSeconds(0.5f);
        GameObject CloneExplosion1 = Instantiate(Explosion1, transform.position + offset2, transform.rotation);
        Destroy(CloneExplosion1, 2f);
        yield return new WaitForSeconds(0.5f);
        GameObject CloneExplosion2 = Instantiate(Explosion2, transform.position + offset3, transform.rotation);
        Destroy(CloneExplosion2, 1.5f);
        yield return new WaitForSeconds(0.5f);
        GameObject CloneExplosion3 = Instantiate(Explosion3, transform.position + offset4, transform.rotation);
        Destroy(CloneExplosion3, 1f);
        Destroy(gameObject);

        EnemyShooting.StopShoot = true;
    }

}
