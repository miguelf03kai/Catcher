using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hi_score : MonoBehaviour {

    public Text h_p;
    int hi_score1 = 0;

	// Use this for initialization
	void Start () {

        hi_score1 = PlayerPrefs.GetInt("Score", 0);

        if (hi_score1 < player.points)
        {
            hi_score1 = player.points;
            PlayerPrefs.SetInt("Score", hi_score1);
            Debug.Log(hi_score1);
        }

        h_p.text = "" + hi_score1;
  
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
