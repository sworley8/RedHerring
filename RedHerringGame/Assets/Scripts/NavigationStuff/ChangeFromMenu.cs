using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeFromMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void changeToSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void changeToGame()
    {
        SceneManager.LoadScene("TutorialIntroScene");
    }
    public void quitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
