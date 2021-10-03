using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createObject : MonoBehaviour {

    public GameObject food = null;
    public GameObject fish = null;
    public GameObject damage = null;
    public GameObject star;
    float[] position = new float[] { -2.372f, -1.486f, -0.604f, 0.281f, 1.164f };
    //float[] vertical_position = new float[] { 5.422f, 4.577f, 3.732f, 2.887f, 2.042f, 1.197f, 0.352f, -0.493f, -1.338f, -2.183f, -3.028f, -3.873f };
    int i = 0;
    int test1 = 0;
    int limit = 0;

    int[] easy = new int[] {14,30,50};
    int[] normal = new int[] {7,15,25};
    int[] hard = new int[] {5,10,20};

    int[] creationTime = new int[] {};

    public int creation = 5;

    public Text lv = null;

    int spawnStar = 0;

	// Use this for initialization
	void Start () {
        //StartCoroutine(Example());

        if (food_gravity.level == 2){
            lv.text = "Easy";
            creation = 5;
            creationTime = easy;
            }
        else if (food_gravity.level == 4){
            lv.text = "Normal";
            creation = 5;
            creationTime = normal;
            }
        else if (food_gravity.level == 5){
            lv.text = "Hard";
            creation = 5;
            creationTime = hard;
            }
     
	}
	
	// Update is called once per frame
	void Update () {
        
        //if (food_gravity.i == 2)
        //{
        //    Debug.Log("test");
        //}
     if (paause.stopped != true)
        {
            //if (limit <= 7)
                StartCoroutine(Example());    
        }
        //Debug.Log(position[2]);
        //Debug.Log(creation);
	}


    IEnumerator Example()
    {

        if (test1 == creationTime[0])
        {
            int type = Random.Range(1,3);
            Debug.Log(spawnStar);
            if(type == 1)
                Instantiate(food, new Vector2(position[Random.Range(0,position.Length)], 7.50f), transform.rotation);
            else if(type == 2)
                Instantiate(fish, new Vector2(position[Random.Range(0,position.Length)], 7.50f), transform.rotation);
             
            //else if(type == 3)
            
            //Instantiate(damage, new Vector2(position[Random.Range(0, position.Length)], 7.00f), Quaternion.identity);
            //Debug.Log(position[i]);
        }

        if (test1 == creationTime[1])
        {
            Instantiate(damage, new Vector2(position[Random.Range(0, position.Length)], 7.50f), transform.rotation);
            
            if(creation == 5 || creation == 1){
                Instantiate(damage, new Vector2(position[Random.Range(0, position.Length)], 7.50f), transform.rotation);
                Debug.Log("Obejct Created");
            }  
            //limit++;
            //Debug.Log("limit "+limit);
        }

        if (test1 == creationTime[2])
            test1 = 0;

        if(spawnStar == 1000){
            Instantiate(star, new Vector2(position[Random.Range(0,position.Length)], 7.50f), transform.rotation);
            Debug.Log("star created");
            spawnStar = 0;
            }
       
        test1++;
        spawnStar++;
        yield return new WaitForSeconds(creation);
        Debug.Log("test1 "+test1);

    }
}
