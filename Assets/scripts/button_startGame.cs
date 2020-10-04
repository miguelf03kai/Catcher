using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_startGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void quiteGame()
    {
        Debug.Log("exiting");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void level()
    {
        SceneManager.LoadScene(3);
    }
}
