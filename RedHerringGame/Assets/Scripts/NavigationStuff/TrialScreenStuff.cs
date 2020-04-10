using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrialScreenStuff : MonoBehaviour
{
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
