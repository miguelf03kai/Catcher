using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createObject : MonoBehaviour {

    public GameObject food = null;
    public GameObject damage = null;
    float[] position = new float[] { -2.372f, -1.486f, -0.604f, 0.281f, 1.164f };
    //float[] vertical_position = new float[] { 5.422f, 4.577f, 3.732f, 2.887f, 2.042f, 1.197f, 0.352f, -0.493f, -1.338f, -2.183f, -3.028f, -3.873f };
    int i = 0;
    int test1 = 0;
    int limit = 0;

    public Text lv = null;

	// Use this for initialization
	void Start () {
        //StartCoroutine(Example());

        if (food_gravity.level == 2)
            lv.text = "Easy";
        else if (food_gravity.level == 4)
            lv.text = "Normal";
        else if (food_gravity.level == 8)
            lv.text = "Hard";
	}
	
	// Update is called once per frame
	void Update () {
        
        //if (food_gravity.i == 2)
        //{
        //    Debug.Log("test");
        //}
        if (paause.stopped != true)
        {
            if (limit <= 10)
                StartCoroutine(Example());
        }
        //Debug.Log(position[2]);
	}


    IEnumerator Example()
    {
        if (test1 == 100)
        {
            Instantiate(food, new Vector2(position[Random.Range(0,position.Length)], 7.112f), Quaternion.identity);
            //Debug.Log(position[i]);
        }

        if (test1 == 180)
        {
            Instantiate(damage, new Vector2(position[Random.Range(0, position.Length)], 7.112f), Quaternion.identity);
            
            limit++;
            Debug.Log("limit "+limit);
        }

        if (test1 == 200)
            test1 = 0;

       
        test1++;
        yield return new WaitForSeconds(3);
        //Debug.Log(test1);

    }
}
