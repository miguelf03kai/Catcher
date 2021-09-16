using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_select : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void normal()
    {
        food_gravity.level = 4;
        enemy.level = 4;
        star.level = 4;
        SceneManager.LoadScene(0);
    }
    public void easy()
    {
        food_gravity.level = 2;
        enemy.level = 2;
        star.level = 2;
        SceneManager.LoadScene(0);
    }
    public void hard()
    {
        food_gravity.level = 8;
        enemy.level = 8;
        star.level = 8;
        SceneManager.LoadScene(0);
    }
}
