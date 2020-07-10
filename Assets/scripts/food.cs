using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour {

    public float init_pos;
    float position_y = 5.406f;
    float random = -2.372f;
    //list positions
    float[] position = new float[] { -2.372f, -1.5f, -0.628f, 0.244f, 1.116f };
 
	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody2D>();
        
        InvokeRepeating("methodWaint", 0.5f,1.0f);
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        random = position[Random.Range(0, position.Length)];

        position_y = init_pos;
        transform.position = new Vector2(random, position_y);

    }


    //Update is called once per frame
    void Update() {
        //Debug.Log(position_y);

        if (transform.position.y < -4.16f)
        {
            //apply specific value from list
            random = position[Random.Range(0, position.Length)];
        }
    }

    void methodWaint()
    {
        if (transform.position.y < -4.16f)
        {
            position_y = init_pos;
            transform.position = new Vector2(random, position_y);
        }
        else
        {
            transform.position = new Vector2(random, position_y);
            position_y -= 0.807f;
        }
    }
}
