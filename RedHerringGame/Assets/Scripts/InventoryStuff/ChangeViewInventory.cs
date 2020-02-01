using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeViewInventory : MonoBehaviour
{
    //public GameObject details;
    //public GameObject slots;
    public GameObject dataWant;
    ToSeeIfPlayerRIght tt;
    void Awake()
    {
        dataWant = GameObject.Find("DataFromDialogue");
        tt = dataWant.GetComponent<ToSeeIfPlayerRIght>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene(tt.sceneNum);
        }
    }
    //public void clickedTransition()
    //{
    //    if (slots.activeSelf)
    //    {
    //        details.SetActive(true);
    //        slots.SetActive(false);
    //    }
    //    else if (details.activeSelf)
    //    {
    //        slots.SetActive(true);
    //        details.SetActive(false);
    //    }
    //}
}
