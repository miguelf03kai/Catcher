using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour {

    int score = 20;
    public Text tx;

	// Use this for initialization
	void Start () {

       tx.text = "" + player.points;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
