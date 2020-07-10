using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_button : MonoBehaviour {

    public Rigidbody2D pl;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void leftClick()
    {
        if (pl.position.x == -2.372f)
        {
            Debug.Log("stay there");
        }
        else
        {
            pl.position = new Vector2(pl.position.x - 0.872f, -3.044f);
        }
    }
}
