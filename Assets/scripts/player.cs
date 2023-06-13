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
    float[] position = new float[] { -2.372f, -1.486f, -0.604f, 0.281f, 1.164f };
    int i = 2;
    public AudioSource coin;
    public AudioSource up;
    public AudioSource damage;
    public AudioSource power;

    public AudioSource music;

    bool tone = false;
    public int tone2 = 0;


	// Use this for initialization
	void Start () {
        points = 0;
        text_life.text = "" + life;
        music.Play();
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "damage")
        {
            life -= 1;
            damage.Play();

            text_life.text = "" + life;   
        }
        else if(coll.gameObject.tag == "food" || coll.gameObject.tag == "fish")
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

        }
        else if(coll.gameObject.tag == "star"){
            points += 1000;
            myPoints.text = "" + points;
            power.Play();

        }
    }

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (i != 4)
            {
                i++;
                transform.position = new Vector2(position[i], -2.94f);
            }
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (i != 0)
            {
                i--;
                transform.position = new Vector2(position[i], -2.94f);
            }
        }

        if (life == 0)
        {
            SceneManager.LoadScene(2);
        }
	}
    
}
