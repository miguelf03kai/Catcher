using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour {

    int score = 20;
    public Text tx;
    public Text h_p;
    public Text lev = null;
    static int hi_score1 = 0;

	// Use this for initialization
	void Start () {

       tx.text = "" + player.points;
       leve();
      
       
	}
	
	// Update is called once per frame
	void Update () {

	}

    void hi_score23()
    {

        if (hi_score1 < player.points)
        {
            hi_score1 = player.points;
            hi_score1 = PlayerPrefs.GetInt("Score", 0);
            h_p.text = "" + hi_score1;
        }
 
    }

    void leve(){

        if (food_gravity.level == 2){
            lev.text = "Easy";
            hi_score.levelTrash = "Easy";
        }
        else if (food_gravity.level == 4){
            lev.text = "Normal";
            hi_score.levelTrash = "Normal";
            }
        else if (food_gravity.level == 5){
            lev.text = "Hard";
            hi_score.levelTrash = "Hard";
        }
    }
}
