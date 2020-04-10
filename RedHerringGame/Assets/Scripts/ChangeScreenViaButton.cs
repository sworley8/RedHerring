using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreenViaButton : MonoBehaviour
{
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire2"))
        {

            foreach (Transform child in screen.transform)
            {
                if (child != screen.transform.GetChild(1))
                {
                    child.gameObject.SetActive(false);
                }
                if (child == screen.transform.GetChild(1))
                {
                    if (child.gameObject.activeInHierarchy)
                    {
                        screen.transform.GetChild(1).gameObject.SetActive(false);
                        screen.transform.GetChild(0).gameObject.SetActive(true);

                    }
                    else
                    {
                        screen.transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
        }
        //child.gameObject.SetActive(true);
        //if (screen.transform.GetChild(1).gameObject.activeInHierarchy)
        //{
        //    screen.transform.GetChild(1).gameObject.SetActive(false);
        //}
        //else
        //{
        //    screen.transform.GetChild(1).gameObject.SetActive(true);
        //}

        //if (screen.transform.GetChild(0).gameObject.activeInHierarchy)
        //{
        //    screen.transform.GetChild(1).gameObject.SetActive(true);
        //    screen.transform.GetChild(0).gameObject.SetActive(false);
        //}
        //if (screen.transform.GetChild(1).gameObject.activeInHierarchy)
        //{
        //    screen.transform.GetChild(1).gameObject.SetActive(true);
        //    screen.transform.GetChild(0).gameObject.SetActive(false);
        //} else
        //{

        //SceneManager.LoadScene(tt.sceneNum);
        //}
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetButtonDown("Fire1"))
        {
            foreach (Transform child in screen.transform)
            {
                if (child != screen.transform.GetChild(2))
                {
                    child.gameObject.SetActive(false);
                }
                if (child == screen.transform.GetChild(2))
                {
                    if (child.gameObject.activeInHierarchy)
                    {
                        screen.transform.GetChild(2).gameObject.SetActive(false);
                        screen.transform.GetChild(0).gameObject.SetActive(true);

                    }
                    else
                    {
                        screen.transform.GetChild(2).gameObject.SetActive(true);
                    }
                }
                //child.gameObject.SetActive(true);
            }
        }
    }
}
