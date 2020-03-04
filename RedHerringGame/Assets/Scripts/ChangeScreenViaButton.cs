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
            if (screen.transform.GetChild(0).gameObject.activeInHierarchy)
            {
                screen.transform.GetChild(1).gameObject.SetActive(true);
                screen.transform.GetChild(0).gameObject.SetActive(false);
            }
            if (screen.transform.GetChild(1).gameObject.activeInHierarchy)
            {
                screen.transform.GetChild(1).gameObject.SetActive(true);
                screen.transform.GetChild(0).gameObject.SetActive(false);
            }

            //SceneManager.LoadScene(tt.sceneNum);
        }
    }
}
