using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialSelfDestruct : MonoBehaviour {
    public float timer = 6f;
    public GameObject Explosion;
    bool RunOnce = true;
    public static bool StopMove = false;
    public static string Missile;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Missile = gameObject.name;
            if (RunOnce) {
                StartCoroutine(Explode());
                RunOnce = false;
            }
            
        }
        
    }

    private IEnumerator Explode()
    {
        
        StopMove = true;    
        GameObject CloneExplosion = Instantiate(Explosion, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Destroy(CloneExplosion);
        Destroy(gameObject);
        StopMove = false;
    }

}
