using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestingTutorial2 : MonoBehaviour
{
    DialogueSystem test;
    public GameObject scriptNorm;
    public GameObject scriptWrong;
    public string correctLine;
    public bool correctLineApplied;
    public int SceneNum;
    // Start is called before the first frame update
    void Start()
    {
        //test = DialogueSystem.instance;
        test = DialogueSystem.ds;
    }
    public string[] s = new string[]
    {
        "Hello, Let us see if this truly works:Sophia",
        "I am really curious",
        "I have no clue what this does so lets find out togther!",
        "Hmm is that how you truly feel:Hero"
    };
    int indexer = 0;
    public int returnSceneNum()
    {
        return SceneNum;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (indexer >= s.Length)
                {
                    indexer = 0;
                }
                talking(s[indexer]);
                indexer++;
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (correctLine == s[indexer-1])
                {
                    correctLineApplied = true;
                }
                else {
                    correctLineApplied = false;
                }
                indexer++;
                SceneManager.LoadScene(sceneName: "InventoryTest");
            }
        }
        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    scriptWrong.SetActive(true);
        //    scriptNorm.SetActive(false);
        //    //scriptWrong.SetActive(true);
        //}
    }
    void talking(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";
        //test.talking(speech, speaker);
        //test.SayAdd(speech, speaker);
        test.talkingoverride(speech, speaker);
    }
}
