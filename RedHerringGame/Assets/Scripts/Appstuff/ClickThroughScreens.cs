using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClickThroughScreens : MonoBehaviour
{
    public GameObject inventory;
    public GameObject map;
    public GameObject bio;
    public GameObject set;
    public GameObject app;
    public void changeScreen()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(name);
        string menu = "MenuScene";
        if (name == menu)
        {
            SceneManager.LoadScene(name);
        }
        //Debug.Log(name);
        if (name == inventory.name)
        {
            inventory.SetActive(true);
            map.SetActive(false);
            bio.SetActive(false);
            set.SetActive(false);
            app.SetActive(false);
            
        }
        if (name == map.name)
        {

            map.SetActive(true);
            inventory.SetActive(false);
            bio.SetActive(false);
            set.SetActive(false);
            app.SetActive(false);
        }
        if (name == bio.name)
        {
            bio.SetActive(true);
            map.SetActive(false);
            inventory.SetActive(false);
            set.SetActive(false);
            app.SetActive(false);
        }
        if (name == set.name)
        {
            set.SetActive(true);
            map.SetActive(false);
            bio.SetActive(false);
            inventory.SetActive(false);
            app.SetActive(false);
        }
    }
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
