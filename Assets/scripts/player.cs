using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    Rigidbody2D rb;
    public float key = 0;
    int life = 10;
    int points = 0;
    public Text myPoints,text_life;
    points p;
    

	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody2D>();
        //p = (points)GetComponent<points>();
        //text_life.text = "" + life;
        //myPoints.text = "" + p.score;
       
	}

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "enemy")
        {
            life -= 1;

            //Debug.Log("you got "+points);
            text_life.text = "" + life;   
        }
        else if(coll.gameObject.tag == "food")
        {
            points += 1;
            myPoints.text = "" + points;

            Debug.Log("what");
        }
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (transform.position.x > 0.244)
            {
                Debug.Log("stay there");
            }
            else
            {
                transform.position = new Vector2(transform.position.x + 0.872f, -3.044f);
            }

        }

        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (transform.position.x == -2.372f)
            {
                Debug.Log("stay there");
            }
            else
            {
                transform.position = new Vector2(transform.position.x - 0.872f, -3.044f);
            }
        }
        

        //if(life == 0){
        //    SceneManager.LoadScene(1);
        //}
	}
}
