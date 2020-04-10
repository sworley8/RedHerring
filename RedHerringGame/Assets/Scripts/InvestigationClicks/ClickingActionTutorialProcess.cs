using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingActionTutorialProcess : MonoBehaviour
{
    public Camera Camera;
    public int numOfCorrectItemsNeed = 1;
    public bool orderMatter = false;
    public List<string> CorrectNames = new List<string>();
    MovementForInvestigation mi;
    public GameObject normalDialogue;
    public GameObject correctDialogue;
    public GameObject towel;
    public GameObject towelnorm;
    public GameObject mirror;
    public GameObject toilet;
    public GameObject gun;
    public GameObject body;
    public GameObject pent;
    public GameObject book;
    public GameObject photo;
    public GameObject can;
    public GameObject moveon;
    public bool done;
    public int sceneNumber;
    public int counting = 0;
    public int countingTowel = 0;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(distanceToOriginPlane);
        if (numOfCorrectItemsNeed == 0 && done)
        {
            moveon.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1"))
        { // if left button pressed...
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.layer == 8)
                {
                    if (hit.transform.name == "Paper towel dispenser")
                    {
                        countingTowel++;
                        if (countingTowel > 5)
                        {
                            towel.SetActive(true);
                        }
                        if (countingTowel < 5)
                        {
                            towelnorm.SetActive(true);
                        }
                    }
                    if (hit.transform.name == "Mirror")
                    {
                        
                        mirror.SetActive(true);
                    }
                    if (hit.transform.name == "Toilet stall")
                    {
                        counting++;
                        if (counting > 2)
                        {
                            hit.collider.gameObject.SetActive(false);
                        }

                    }
                    if (hit.transform.name == "Toilet")
                    {
                        
                        toilet.SetActive(true);
                    }
                    if (hit.transform.name == "Gun")
                    {
                        
                        gun.SetActive(true);
                    }
                    if (hit.transform.name == "Body")
                    {
                        
                        body.SetActive(true);
                    }
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
                        if (hit.transform.name == "Pentagram")
                        {
                            pent.SetActive(true);
                        }
                        if (hit.transform.name == "Book")
                        {
                            book.SetActive(true);
                        }
                        if (hit.transform.name == "Photo")
                        {
                            photo.SetActive(true);
                        }
                        if (hit.transform.name == "CandleStick")
                        {
                            can.SetActive(true);
                        }
                        //correctDialogue.SetActive(true);
                    }

                    ////item to move along story
                }

            }
            
        }
    }
}
