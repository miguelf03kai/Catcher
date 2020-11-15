using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    float[] position = new float[] { -2.372f, -1.486f, -0.604f, 0.281f, 1.164f };
    int i = 0;

    public static int level = 2;
	// Use this for initialization
	void Start () {
        
	}

   void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            float random = position[Random.Range(0, position.Length)];
            //Debug.Log(random);

            i = 0;
            transform.position = new Vector2(random, 5.57f);//vertical_position[i]);
        }

        if (coll.gameObject.tag == "damage")
            Destroy(gameObject);
    }

	// Update is called once per frame
	void Update () {
        float speed = level * Time.deltaTime;

        if (transform.position.y < -3.873f)
        {
            //transform.position = new Vector2(position[Random.Range(0,position.Length)],5.57f);
            //Debug.Log("test");
            Destroy(gameObject);
        }

        transform.Translate(Vector3.down * speed);
    }
}
