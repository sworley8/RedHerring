using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //Change to scene just on or go to new scene because was correct
    CorrectItemForInventory cii;
    TestingTutorial2 tt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void changeScene()
    {
        if (tt.correctLineApplied)
        {
            GameObject correctForLine = cii.correctObjects[tt.SceneNum];
        } else
        {
            SceneManager.LoadScene(tt.SceneNum);
        }
    }
}
