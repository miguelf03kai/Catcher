using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour {


    public static bool stopped = false;
    public Text p = null;

    AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GameObject.FindGameObjectWithTag("Player").GetComponent<player>().music;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pause1()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            stopped = false;
            p.text = "Pause";
            audioSource.Play();
            
        }
        else if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            Debug.Log("paused");
            stopped = true;
            p.text = "Resume";
            audioSource.Pause();
        }
    }
}
