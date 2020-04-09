using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactivate : MonoBehaviour
{
    public GameObject scriptNorm;
    public GameObject scriptWrong;
    public GameObject scriptNormSpot;
    public GameObject scriptWrongSpot;
    public PronounAndAvatar pa;
    public int i;

    // Start is called before the first frame update
    private void Awake()
    {
        pa = (PronounAndAvatar)GameObject.FindObjectOfType(typeof(PronounAndAvatar));
        
        if (pa.pronoun == "male")
        {
            i = 0;
        }
        if (pa.pronoun == "female")
        {
            i = 1;
        }
        if (pa.pronoun == "nonbinary")
        {
            i = 2;
        }
        scriptNorm = scriptNormSpot.transform.GetChild(i).gameObject;
    }
    void Start()
    {
        //pa = (PronounAndAvatar)GameObject.FindObjectOfType(typeof(PronounAndAvatar));
        //int i = 3;
        //if (pa.pronoun == "male")
        //{
        //    i = 0;
        //}
        //if (pa.pronoun == "female")
        //{
        //    i = 1;
        //}
        //if (pa.pronoun == "nonbinary")
        //{
        //    i = 2;
        //}
        //scriptNorm = scriptNormSpot.transform.GetChild(i).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!scriptNorm.activeSelf && !scriptWrong.activeSelf)
        {
            scriptWrong = scriptWrongSpot.transform.GetChild(i).gameObject;
            scriptWrong.SetActive(true);
            if (scriptWrong.GetComponent<TrialArg1>() != null)
            {
                scriptWrong.GetComponent<TrialArg1>().indexer = 0;
            }
            if (scriptWrong.GetComponent<TrialArg2>() != null)
            {
                scriptWrong.GetComponent<TrialArg2>().indexer = 0;
            }
            if (scriptWrong.GetComponent<TrialArg3>() != null)
            {
                scriptWrong.GetComponent<TrialArg3>().indexer = 0;
            }
            //scriptWrong.GetComponent<TestingTutorial2>().indexer = 0;

        }
    }
}
