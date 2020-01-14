using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewInventory : MonoBehaviour
{
    public GameObject details;
    public GameObject slots;
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
    public void clickedTransition()
    {
        if (slots.activeSelf)
        {
            details.SetActive(true);
            slots.SetActive(false);
        }
        else if (details.activeSelf)
        {
            slots.SetActive(true);
            details.SetActive(false);
        }
    }
}
