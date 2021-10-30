using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hi_score : MonoBehaviour {

    //public Text h_p;
    int hi_score1Easy = 0;
    int hi_score1Normal = 0;
    int hi_score1Hard = 0;
    public static string levelTrash = "kai";

	// Use this for initialization
	void Start () {

     Debug.Log(levelTrash);
      
      hi_score1Easy = PlayerPrefs.GetInt("Easy", 0);
      hi_score1Normal = PlayerPrefs.GetInt("Normal", 0);
      hi_score1Hard = PlayerPrefs.GetInt("Hard", 0);

      if(levelTrash == "Easy"){
            if (hi_score1Easy < player.points)
            {
                hi_score1Easy = player.points;
                PlayerPrefs.SetInt("Easy", hi_score1Easy);
                Debug.Log(hi_score1Easy);
            }
      }
      if(levelTrash == "Normal"){
            if (hi_score1Normal < player.points)
            {
                hi_score1Normal = player.points;
                PlayerPrefs.SetInt("Normal", hi_score1Normal);
                Debug.Log("level Normal "+hi_score1Normal);
            }
      }
      if(levelTrash == "Hard"){
          Debug.Log("Level Hard");
            if (hi_score1Hard < player.points)
            {
                hi_score1Hard = player.points;
                PlayerPrefs.SetInt("Hard", hi_score1Hard);
                Debug.Log("level hard "+hi_score1Hard);
            }
      }

        //h_p.text = "" + hi_score1;
  
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(levelTrash);
	}
}
