using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class food_gravity : MonoBehaviour {


    float random = -2.372f;
    float position_y = 5.406f;
    float[] position = new float[] { -2.372f, -1.486f, -0.604f, 0.281f, 1.164f };
    float[] vertical_position = new float[] { 7.112f, 6.267f, 5.422f, 4.577f, 3.732f, 2.887f, 2.042f, 1.197f, 0.352f, -0.493f, -1.338f, -2.183f, -3.028f, -3.873f };
    int i = 0;
    int object_s = 2;

    public static int level = 2;


    // Use this for initialization
	void Start () {

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {

        float speed = level * Time.deltaTime;

        if (transform.position.y < -3.873f)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.down * speed);

	}

}
