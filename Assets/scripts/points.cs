using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour {

    int score = 20;
    public Text tx;
    public Text h_p;
    static int hi_score1 = 0;

	// Use this for initialization
	void Start () {

       tx.text = "" + player.points;
       
	}
	
	// Update is called once per frame
	void Update () {

	}

    void hi_score()
    {

        if (hi_score1 < player.points)
        {
            hi_score1 = player.points;
            hi_score1 = PlayerPrefs.GetInt("Score", 0);
            h_p.text = "" + hi_score1;
        }
 
    }
}
