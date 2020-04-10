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
    MovementForInvestigation mi;
    public GameObject normalDialogue;
    public GameObject correctDialogue;
    public int sceneNumber;
    public int counting = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(distanceToOriginPlane);
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1"))
        { // if left button pressed...
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.layer == 8)
                {
                    normalDialogue.SetActive(true);
                    
                    //gameObject.SetActive(true);

                    //Indicates click one then other object
                    //if (hit.transform.name == "Capsule")
                    //{
                    //    //prompt the proper dialogue here to move story
                    //    Debug.Log("This is not Cube");
                    //    orderMatter = true;
                    //}

                    ////not what wanted to move along story

                    //if (hit.transform.name == "Cube")
                    //{
                    //    orderMatter = true;
                    //    //prompt the dummy dialogue here to hint where to go
                    //    Debug.Log("This is Cube");
                    //}
                }
                if (hit.transform.gameObject.layer == 9)
                {
                    //Click on correct item
                    if (!CorrectNames.Contains(hit.transform.name))
                    {
                        CorrectNames.Add(hit.transform.name);
                        numOfCorrectItemsNeed--;

                        correctDialogue.SetActive(true);
                    }
                    
                    ////item to move along story
                }
            }
        }
    }
}
