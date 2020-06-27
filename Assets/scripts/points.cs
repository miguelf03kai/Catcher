using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour {

    public int score = 20;
    public Text tx;
	// Use this for initialization
	void Start () {
        tx.text = "" + score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
