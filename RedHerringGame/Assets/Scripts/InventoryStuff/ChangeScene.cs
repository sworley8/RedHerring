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
    public GameObject gameObjectie;
    //public GameObject inventoryScreen;
    int newScene;
    // Start is called before the first frame update
    void Awake()
    {
        dataWant = GameObject.Find("DataFromDialogue");
        tt = dataWant.GetComponent<ToSeeIfPlayerRIght>();
        itemWant = GameObject.Find("Creation");
        cii = itemWant.GetComponent<CreateItem>();
        gameObjectie = GameObject.FindGameObjectWithTag("panel");
        
        
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
                if (tt.sceneNum == 14) {
                    if ((this.gameObject.name == "Photo") && cii.correctNameForLine[1] && tt.correctLinePicked)
                    {
                        newScene = tt.sceneNum + 1;

                        Debug.Log(newScene);
                        this.gameObject.GetComponent<Toggle>().isOn = false;
                        //Debug.Log(cii.maybeNames[j]);

                        SceneManager.LoadScene(newScene);
                    }
                    else
                    {

                        tt.cameBackForMore = true;
                        this.gameObject.GetComponent<Toggle>().isOn = false;
                        gameObjectie.transform.GetChild(0).gameObject.SetActive(true);
                        //Currently stuck isnt at wrong dialogue yet
                        gameObjectie.transform.GetChild(1).gameObject.SetActive(false);
                        //SceneManager.LoadScene(tt.sceneNum);
                    }
                }
                if (tt.sceneNum == 16)
                {
                    if ((this.gameObject.name == "Book") && cii.correctNameForLine[2] && tt.correctLinePicked)
                    {
                        newScene = tt.sceneNum + 1;
                        Debug.Log(newScene);
                        this.gameObject.GetComponent<Toggle>().isOn = false;
                        //Debug.Log(cii.maybeNames[j]);

                        SceneManager.LoadScene(newScene);
                    }
                    else
                    {
                        //Debug.Log(cii.correctNameForLine[2]);
                        tt.cameBackForMore = true;
                        this.gameObject.GetComponent<Toggle>().isOn = false;
                        gameObjectie.transform.GetChild(0).gameObject.SetActive(true);
                        //Currently stuck isnt at wrong dialogue yet
                        gameObjectie.transform.GetChild(1).gameObject.SetActive(false);
                        //SceneManager.LoadScene(tt.sceneNum);
                    }
                }
            if (tt.sceneNum == 18)
            {
                if ((this.gameObject.name == "Candlestick") && cii.correctNameForLine[3] && tt.correctLinePicked)
                {
                    newScene = tt.sceneNum + 1;
                    Debug.Log(newScene);
                    this.gameObject.GetComponent<Toggle>().isOn = false;
                    //Debug.Log(cii.maybeNames[j]);

                    SceneManager.LoadScene(newScene);
                }
                else
                {
                    Debug.Log(this.gameObject.name);
                    tt.cameBackForMore = true;
                    this.gameObject.GetComponent<Toggle>().isOn = false;
                    gameObjectie.transform.GetChild(0).gameObject.SetActive(true);
                    //Currently stuck isnt at wrong dialogue yet
                    gameObjectie.transform.GetChild(1).gameObject.SetActive(false);
                    //SceneManager.LoadScene(tt.sceneNum);
                }
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
