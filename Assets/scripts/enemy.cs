using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void OnTriggerEnter2D(Collider2D other) {

        transform.position = new Vector2(Random.Range(-5.76f, 2.41f), 5.96f);
    
    }


	// Update is called once per frame
	void Update () {
        //rb.AddForce(new Vector2(0,-speed_fall));
         transform.Translate(0,-0.03f,0);

         if (transform.position.y <= -6.03f)
         {
             //change the position of food
             transform.position = new Vector2(Random.Range(-5.76f, 2.41f), 5.96f);   
         }
	}
}
