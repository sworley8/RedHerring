using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    //Change to scene just on or go to new scene because was correct
    CreateItem cii;
    public GameObject dataWant;
    public GameObject itemWant;
    ToSeeIfPlayerRIght tt;
    SelectItem si;
    //public GameObject gameObjectie;
    //public GameObject inventoryScreen;
    int newScene;
    // Start is called before the first frame update
    void Awake()
    {
        dataWant = GameObject.Find("DataFromDialogue");
        tt = dataWant.GetComponent<ToSeeIfPlayerRIght>();
        itemWant = GameObject.Find("Creation");
        cii = itemWant.GetComponent<CreateItem>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeScene();
            //SceneManager.LoadScene(tt.sceneNum);
        }
    }
    void changeScene()
    {
        if (this.gameObject.GetComponent<Toggle>().isOn)
        {
            //for (int j = 0; j < cii.maybeNames.Count; j++)
            //{
                if ((this.gameObject.name == "Sphere") && cii.correctNameForLine[0])
                {
                    newScene = tt.sceneNum + 2;
                    Debug.Log(newScene);
                    //Debug.Log(cii.maybeNames[j]);

                    SceneManager.LoadScene(newScene);
                } else
                {
                    tt.cameBackForMore = true;
                    SceneManager.LoadScene(tt.sceneNum);
                }
            //}
            //gameObjectie.transform.GetChild(0).gameObject.SetActive(true);
            //gameObjectie.transform.GetChild(1).gameObject.SetActive(false);
            //dialogueScreen.SetActive(true);
            //inventoryScreen.SetActive(false);
            //Debug.Log(tt.cameBackForMore);
            //SceneManager.LoadScene(tt.sceneNum);
            //SceneManager.LoadScene(tt.sceneNum);
        }

        //} else
        //{
        //    SceneManager.LoadScene(tt.sceneNum);
        //}
    }
}
