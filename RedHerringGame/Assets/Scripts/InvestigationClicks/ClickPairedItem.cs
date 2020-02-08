using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickPairedItem : MonoBehaviour
{
    public GameObject objectBoi;
    public ClickingAction ca;
    // Start is called before the first frame update
    void Start()
    {
        objectBoi.GetComponent<SphereCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //DO THIS PART FOR PAIRING THINGS IF NEED BE
        if (ca.orderMatter == true)
        {
            objectBoi.GetComponent<SphereCollider>().enabled = true;
        }
    }
}
