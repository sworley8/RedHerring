using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class QuickTravelViaMap : MonoBehaviour
{
    public int floor = 1;
    public GameObject floor0;
    public GameObject floor1;
    public GameObject floor2;
    public GameObject floor3;

    public void NextScene()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(name);
        SceneManager.LoadScene(name);
    }
    public void changeFloorUp()
    {
        if (floor == 3)
        {
            floor0.SetActive(true);
            floor1.SetActive(false);
            floor2.SetActive(false);
            floor3.SetActive(false);
            floor = 0;
        }
        if (floor == 2)
        {
            floor3.SetActive(true);
            floor1.SetActive(false);
            floor2.SetActive(false);
            floor0.SetActive(false);
            floor++;
        }
        if (floor == 1)
        {
            floor2.SetActive(true);
            floor1.SetActive(false);
            floor0.SetActive(false);
            floor3.SetActive(false);
            floor++;
        }
        if (floor == 0)
        {
            floor1.SetActive(true);
            floor0.SetActive(false);
            floor2.SetActive(false);
            floor3.SetActive(false);
            floor++;
        }
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void credits()
    {
        SceneManager.LoadScene(2);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

}
