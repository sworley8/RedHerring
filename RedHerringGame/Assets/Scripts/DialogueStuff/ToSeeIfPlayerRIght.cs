using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSeeIfPlayerRIght : MonoBehaviour
{
    public GameObject dataWant;
    public GameObject scriptNormSpot;
    public TrialArg1 testing;
    public TrialArg2 testing1;
    public TrialArg3 testing2;
    public GameObject thisData;
    public int sceneNum = 1;
    public bool correctLinePicked = false;
    public bool cameBackForMore = false;
    public int livesLeft;
    public PronounAndAvatar pa;

    // Start is called before the first frame update
    //private void Awake()
    //{
    //    DontDestroyOnLoad(thisData);
    //}
    void Start()
    {
        //dataWant = ra.scriptNorm;
        pa = (PronounAndAvatar)GameObject.FindObjectOfType(typeof(PronounAndAvatar));
        int i = 0;
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
        dataWant = scriptNormSpot.transform.GetChild(i).gameObject;
        //dataWant = GameObject.Find("NormalDialogue");

        testing = dataWant.GetComponent<TrialArg1>();
        if (testing == null)
        {
            testing1 = dataWant.GetComponent<TrialArg2>();
        }
        testing1 = dataWant.GetComponent<TrialArg2>();
        testing2 = dataWant.GetComponent<TrialArg3>();
    }

    // Update is called once per frame
    void Update()
    {
        bool fake = true;
        if (testing != null)
        {
            //Debug.Log(testing1.correctLineApplied);
            if (testing.correctLineApplied)
            {
                correctLinePicked = true;
            }
        }
        if (testing1 != null)
        {

            if (testing1.correctLineApplied)
            {
                Debug.Log(testing1.correctLineApplied);
                correctLinePicked = true;
            }
        }

        if (testing2 != null)
        {
            if (testing2.correctLineApplied)
            {
                correctLinePicked = true;
            }
        }
        
        //correctLinePicked = testing.correctLineApplied;
        //correctLinePicked = testing1.correctLineApplied;
        //correctLinePicked = testing2.correctLineApplied;

    }

}
