using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickingAction : MonoBehaviour
{
    public Camera Camera;
    public int numOfCorrectItemsNeed = 1;
    public bool orderMatter = false;
    public List<string> CorrectNames = new List<string>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numOfCorrectItemsNeed == 0)
        {
            SceneManager.LoadScene(sceneName: "TutorialTrialScene");
        }
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire2"))
        { // if left button pressed...
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.layer == 8)
                {
                    //Indicates click one then other object
                    if (hit.transform.name == "Capsule")
                    {
                        //prompt the proper dialogue here to move story
                        Debug.Log("This is not Cube");
                        orderMatter = true;
                    }

                    //not what wanted to move along story
                    Debug.Log("Hit");
                    if (hit.transform.name == "Cube")
                    {
                        orderMatter = true;
                        //prompt the dummy dialogue here to hint where to go
                        Debug.Log("This is Cube");
                    }
                }
                if (hit.transform.gameObject.layer == 9)
                {
                    //Click on correct item
                    if (!CorrectNames.Contains(hit.transform.name))
                    {
                        CorrectNames.Add(hit.transform.name);
                        numOfCorrectItemsNeed--;
                        Debug.Log("This is not Cube BROOOOOO");
                    }
                    ////item to move along story
                }
            }
        }
    }
}
