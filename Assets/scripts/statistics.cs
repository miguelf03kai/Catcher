using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statistics : MonoBehaviour {

    public Text pointsEasy;
	public Text pointsNormal;
	public Text pointsHard;


    int PlayerPoint;

	// Use this for initialization
	void Start () {
		
		pointsEasy.text = ""+PlayerPrefs.GetInt("Easy", 0);

		pointsHard.text = ""+PlayerPrefs.GetInt("Hard", 0);

		pointsNormal.text = ""+PlayerPrefs.GetInt("Normal", 0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
