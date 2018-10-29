using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawner : MonoBehaviour {

    public float speed = 0.1f;
    public float sideSpeed = 1f;
    Vector3 LeftOrRight = Vector3.left;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

            LayerMask mask = LayerMask.GetMask("EnemyShootOrNot");
            RaycastHit2D TurnOrNot = Physics2D.Raycast(gameObject.transform.position, Vector2.down, 50f, mask);

            transform.Translate(Vector3.up * speed * Time.deltaTime);
            

        if (TurnOrNot.collider == false) {
            if (LeftOrRight == Vector3.left) {
                LeftOrRight = Vector3.right;
            }
            else
            {
                LeftOrRight = Vector3.left;
            }
        }
    
        transform.Translate(LeftOrRight * sideSpeed * Time.deltaTime);
        StartCoroutine(Delay());
    }



    private IEnumerator Delay() {

        yield return new WaitForSeconds(3f);
    }

}
