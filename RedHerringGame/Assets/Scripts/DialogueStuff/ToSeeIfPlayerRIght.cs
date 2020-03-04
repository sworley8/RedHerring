using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSeeIfPlayerRIght : MonoBehaviour
{
    public GameObject dataWant;
    public GameObject scriptNormSpot;
    TestingTutorial2 testing;
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
        testing = dataWant.GetComponent<TestingTutorial2>();
    }

    // Update is called once per frame
    void Update()
    {
        sceneNum = testing.SceneNum;
        correctLinePicked = testing.correctLineApplied;

    }

}
