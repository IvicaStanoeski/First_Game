using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageHandlerPlayer : MonoBehaviour {
    
    public static int PlayerHealth = 3;
    public GameObject shield;
    public GameObject Explosion;
    public GameObject Explosion1;
    public GameObject Explosion2;
    static public bool StopMove = true;
    static public bool RemoveClamp = false;
    bool PlayerHit = false;
    // Use this for initialization
    void Start () {
            
    }
	
	// Update is called once per frame
	void Update () {

        if (PlayerHit) {
            PlayerHealth--;
            PlayerHit = false;
        }

        if (PlayerHealth <= 0)
        {
            StartCoroutine(Delay());
            SceneManager.LoadScene("DefeatScene");
        }
        
    }

    

    void OnTriggerEnter2D()
    {
            gameObject.layer = 10;
            PlayerHit = true;
            StartCoroutine(Explode());
            StartCoroutine(Respawn());
            ScoreBoard.Score -= 100;

    }

    private IEnumerator Explode() {
            Vector3 offset1 = new Vector3(0.27f,0.18f,0);
            Vector3 offset2 = new Vector3(-0.23f, -0.23f, 0);
            RemoveClamp = true;
            GameObject CloneExplosion = Instantiate(Explosion, transform.position, transform.rotation);
            Destroy(CloneExplosion, 1.8f);
            yield return new WaitForSeconds(0.5f);
            GameObject CloneExplosion1 = Instantiate(Explosion1, transform.position + offset1, transform.rotation);
            Destroy(CloneExplosion1, 1.3f);
            yield return new WaitForSeconds(0.5f);
            GameObject CloneExplosion2 = Instantiate(Explosion2, transform.position + offset2, transform.rotation);
            Destroy(CloneExplosion2, 0.8f);
            
    }
  
    private IEnumerator Respawn() {

        
        StopMove = false;
        Shooting.StopShoot = false;
        yield return new WaitForSeconds(1.8f);
        Vector3 RespawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;
        gameObject.transform.position = RespawnPoint;
        StopMove = true;
        Shooting.StopShoot = true;
        RemoveClamp = false;
        gameObject.layer = 10;
        shield.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        shield.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        shield.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        shield.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        shield.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        shield.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        shield.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        shield.SetActive(false);
        gameObject.layer = 8;

    }


    private IEnumerator Delay() {

        yield return new WaitForSeconds(1.8f);
    }
}


