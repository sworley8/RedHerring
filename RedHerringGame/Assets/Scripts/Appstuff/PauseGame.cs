using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
	public GameObject appscreen;
	public GameObject currentscreen;
	public bool GamePaused;

	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{

		//uses the p button to pause and unpause the game
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GamePaused)
			{
				StartUp();
			}
			else {
				Pause();
            }
			
		}
	}
    void StartUp()
    {
		appscreen.SetActive(false);
		//Time.timeScale = 1f;
		GamePaused = false;
	}
    void Pause()
    {
		appscreen.SetActive(true);
		Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
	
		GamePaused = true;
    }
    


}
