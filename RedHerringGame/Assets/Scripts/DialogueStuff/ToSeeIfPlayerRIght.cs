using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSeeIfPlayerRIght : MonoBehaviour
{
    public GameObject dataWant;
    TestingTutorial2 testing;
    public GameObject thisData;
    public int sceneNum = 1;
    public bool correctLinePicked = false;
    public bool cameBackForMore = false;
    public int livesLeft;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(thisData);
    }
    void Start()
    {
        dataWant = GameObject.Find("NormalDialogue");
        testing = dataWant.GetComponent<TestingTutorial2>();
    }

    // Update is called once per frame
    void Update()
    {
        sceneNum = testing.SceneNum;
        correctLinePicked = testing.correctLineApplied;
    }

}
