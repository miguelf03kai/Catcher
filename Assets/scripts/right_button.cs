using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_button : MonoBehaviour {

    public Rigidbody2D pl;

    float[] position = new float[] { -2.372f, -1.486f, -0.604f, 0.281f, 1.164f };
    int i = 2;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void click()
    {
        if (pl.position.x > 0.281f)
        {
            Debug.Log("stay there");
        }
        else
        {
            pl.position = new Vector2(pl.position.x + 0.872f, -2.94f);
        }
        //if (i == 4)
        //{
        //    Debug.Log("Stop Here");
        //}
        //else
        //{
        //    i++;
        //    transform.position = new Vector2(pl.position[i], -3.044f);
        //}
    }
}
