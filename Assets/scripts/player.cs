using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    Rigidbody2D rb;
    public float key = 0;
    public int life = 3;
    public static int points;
    public Text myPoints,text_life;
    points p;
    //float init_position = -0.604f;
    float[] position = new float[] { -2.372f, -1.486f, -0.604f, 0.281f, 1.164f };
    int i = 2;
    public AudioSource coin;
    public AudioSource up;
    public AudioSource damage;

    bool tone = false;
    int tone2 = 0;


	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody2D>();
        //p = (points)GetComponent<points>();
        points = 0;
        text_life.text = "" + life;
        //myPoints.text = "" + p.score;

        //Debug.Log(position[3]);

        //transform.position = new Vector2(-0.604f, -3.044f);
       
        //coin = GetComponent<AudioSource>();
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "damage")
        {
            life -= 1;
            damage.Play();

            //Debug.Log("you got "+points);
            text_life.text = "" + life;   
        }
        else if(coll.gameObject.tag == "food")
        {
            points += 10;
            tone2 +=1; 
            if(tone2 == 10)
                tone = true;

            myPoints.text = "" + points;

            if (tone == true)
            {
                up.Play();
                tone2 = 0;
                tone = false;
            }
            else
                coin.Play();

            //Debug.Log(points);
        }
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (i == 4)
            {
                //Debug.Log("Stop Here");
            }
            else
            {
                i++;
                transform.position = new Vector2(position[i], -3.044f);
            }

        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (i == 0)
            {
                //Debug.Log("Stop Here");
            }
            else
            {
                i--;
                transform.position = new Vector2(position[i], -3.044f);
            }

        }
        
        


        //if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    if (transform.position.x == 1.112269f)
        //    {
        //        Debug.Log("stay there");
        //    }
        //    else
        //    {
        //        transform.position = new Vector2(transform.position.x + 0.872f, -3.044f);
        //    }

        //}

        //else if (Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    if (transform.position.x == -2.359377f)
        //    {
        //        Debug.Log("stay there");
        //    }
        //    else
        //    {
        //        transform.position = new Vector2(transform.position.x - 0.872f, -3.044f);
        //    }
        //}

        if (life == 0)
        {
            SceneManager.LoadScene(2);
        }
	}
    
}
