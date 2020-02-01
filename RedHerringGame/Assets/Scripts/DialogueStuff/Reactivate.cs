using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactivate : MonoBehaviour
{
    public GameObject scriptNorm;
    public GameObject scriptWrong;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!scriptNorm.activeSelf && !scriptWrong.activeSelf)
        {
            scriptWrong.SetActive(true);
            scriptWrong.GetComponent<TestingTutorial2>().indexer = 0;
        }
    }
}
