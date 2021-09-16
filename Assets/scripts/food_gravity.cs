using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class food_gravity : MonoBehaviour {


    //public float init_pos = 5.422f;
    float random = -2.372f;
    float position_y = 5.406f;
    float[] position = new float[] { -2.372f, -1.486f, -0.604f, 0.281f, 1.164f };
    float[] vertical_position = new float[] { 7.112f, 6.267f, 5.422f, 4.577f, 3.732f, 2.887f, 2.042f, 1.197f, 0.352f, -0.493f, -1.338f, -2.183f, -3.028f, -3.873f };
    int i = 0;
    int object_s = 2;

    public static int level = 2;


    // Use this for initialization
	void Start () {
        //InvokeRepeating("methodWait", 0.5f, 0.5f);
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

        if (coll.gameObject.tag == "damage" || coll.gameObject.tag == "food" || coll.gameObject.tag == "fish" || coll.gameObject.tag == "star")
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

    //void methodWait()
    //{
    //    i++;

    //    if (i == 13)
    //    {
    //        float random = position[Random.Range(0, position.Length)];
    //        //Debug.Log(random);

    //        i = 0;
    //        transform.position = new Vector2(random, vertical_position[i]);
    //    }

    //    transform.position = new Vector2(transform.position.x, vertical_position[i]);
        

    //}

}
