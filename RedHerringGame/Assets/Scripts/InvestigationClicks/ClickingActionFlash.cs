using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingActionFlash : MonoBehaviour
{
    public Camera Camera;
    public int numOfCorrectItemsNeed = 1;
    public bool orderMatter = false;
    public List<string> CorrectNames = new List<string>();
    MovementForInvestigation mi;
    public GameObject normalDialogue;
    public GameObject correctDialogue;
    public GameObject fire;
    public GameObject pil;
    public GameObject axe;
    public GameObject comp;
    public GameObject gamecase;
    public GameObject nah;
    public GameObject fly;
    public GameObject candle;
    //public GameObject photo;
    //public GameObject can;
    //public GameObject moveon;
    public bool done;
    public int sceneNumber;
    public int counting = 0;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(distanceToOriginPlane);
        //if (numOfCorrectItemsNeed == 0 && done)
        //{
        //    moveon.SetActive(true);
        //}
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1"))
        { // if left button pressed...
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.layer == 8)
                {
                    nah.SetActive(true);
                    //if (hit.transform.name == "Paper towel dispenser")
                    //{
                    //    //countingTowel++;
                    //    //if (countingTowel > 5)
                    //    //{
                    //    //    towel.SetActive(true);
                    //    //}
                    //    //if (countingTowel < 5)
                    //    //{
                    //    //    towelnorm.SetActive(true);
                    //    //}
                    //}

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
                        if (hit.transform.name == "Flyer")
                        {
                            fly.SetActive(true);
                        }
                        if (hit.transform.name == "Axe and Lighter")
                        {
                            axe.SetActive(true);
                        }
                        if (hit.transform.name == "Case")
                        {
                            gamecase.SetActive(true);
                        }
                        if (hit.transform.name == "Computer")
                        {
                            comp.SetActive(true);
                        }
                        if (hit.transform.name == "Firework")
                        {
                            fire.SetActive(true);
                        }
                        if (hit.transform.name == "Pillow")
                        {
                            pil.SetActive(true);
                        }
                        if (hit.transform.name == "Candle")
                        {
                            candle.SetActive(true);
                        }
                        //correctDialogue.SetActive(true);
                    }
                }
            }
        }
    }
}
