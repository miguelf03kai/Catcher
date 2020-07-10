using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right_button : MonoBehaviour {

    public Rigidbody2D pl;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void click()
    {
        if (pl.position.x > 0.244)
        {
            Debug.Log("stay there");
        }
        else
        {
            pl.position = new Vector2(pl.position.x + 0.872f, -3.044f);
        }
    }
}
