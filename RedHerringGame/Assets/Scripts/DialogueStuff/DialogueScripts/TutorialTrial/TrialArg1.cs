using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialArg1 : MonoBehaviour
{
    DialogueSystem test;
    public GameObject scriptNormSpot;
    public GameObject scriptNorm;
    public GameObject scriptWrong;
    public GameObject scriptWrongSpot;
    public string correctLine;
    public bool correctLineApplied;
    public GameObject player;
    public int indexer;
    public bool dataInfo;
    public GameObject lives;
    public GameObject gameObjectie;
    public GameObject dialogueBox;
    public PronounAndAvatar pa;

    // Start is called before the first frame update
    private void Awake()
    {
        pa = (PronounAndAvatar)GameObject.FindObjectOfType(typeof(PronounAndAvatar));
        int i = 0;
        Debug.Log(pa.pronoun);
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
        Debug.Log(i);
        //scriptNorm = scriptNormSpot.transform.GetChild(i).gameObject;
        //scriptWrong = scriptWrongSpot.transform.GetChild(i).gameObject;
        lives = GameObject.FindGameObjectWithTag("Player");


    }
    void Start()
    {

        //scriptNorm = ra.scriptNorm;
        //test = DialogueSystem.instance;
        test = DialogueSystem.ds;
        correctLine = "Why would I perform a ritual on someone I have never met";


        indexer = 0;
        talking(s[indexer]);
        indexer++;


        //player = GameObject.FindGameObjectWithTag("Player");
    }
    //    No, that’s a lie, you dirty liar.How dare you say something like that?- Occultist
    //* Why would I perform a ritual on someone I have never met- Occultist
    //This must all be a dream.Yeah, I am dreaming.- Occultist
    //If the ritual actually worked then…..- Occultist
    //Since it is your first time, I will help you.Didn’t one of those statements sound false based on what you saw in the bathroom?- Siri

    public string[] s = new string[]
    {
        "No, that’s a lie, you dirty liar.How dare you say something like that?:Occulist",
        "Why would I perform a ritual on someone I have never met",//correct line
        "This must all be a dream.Yeah, I am dreaming.",
        "If the ritual actually worked then…...",
        "Since it is your first time, I will help you.Didn’t one of those statements sound false based on what you saw in the bathroom?:Siri",
    };

    // Update is called once per frame
    void Update()
    {

        dataInfo = GameObject.FindGameObjectWithTag("data").GetComponent<ToSeeIfPlayerRIght>().cameBackForMore;
        //Debug.Log("hi");
        if (dataInfo)
        {
            Debug.Log("hello");
            GameObject.FindGameObjectWithTag("data").GetComponent<ToSeeIfPlayerRIght>().cameBackForMore = false;
            //lives.GetComponent<PlayerHealth>().handleHealth();
            scriptNorm.SetActive(false);
            scriptWrongSpot.SetActive(true);
            scriptWrong.SetActive(true);
            scriptWrong.GetComponent<TrialArg1>().indexer = 0;
        }
        if (indexer == 0 && !(scriptWrong.activeSelf))
        {
            talking(s[indexer]);
            indexer++;
        }
        if (indexer == 0 && (scriptWrong.activeSelf))
        {
            talking(s[indexer]);
            indexer++;
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Fire1"))
        {
            //Debug.Log(player.transform.GetChild(3).gameObject.name);
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (indexer >= s.Length && !(scriptWrongSpot.activeSelf))
                {
                    Debug.Log(scriptWrong.activeSelf);
                    player.transform.GetChild(2).gameObject.SetActive(false);
                    player.transform.GetChild(1).gameObject.SetActive(true);
                    player.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    indexer = 0;

                }
                if (indexer >= s.Length && (scriptWrongSpot.activeSelf))
                {
                    
                    player.transform.GetChild(1).gameObject.SetActive(true);
                    player.transform.GetChild(2).gameObject.SetActive(false);
                    player.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    lives.GetComponent<PlayerHealth>().handleHealth();
                    Debug.Log(scriptWrong.GetComponent<TrialArg1>().indexer);
                    scriptWrong.SetActive(false);
                    scriptWrongSpot.SetActive(false);
                    scriptNorm.SetActive(true);
                    scriptNorm.GetComponent<TrialArg1>().indexer = 0;
                }
                if (indexer == s.Length-1 && (scriptWrongSpot.activeSelf))
                {
                    
                    //Debug.Log(scriptWrong.activeSelf);
                    player.transform.GetChild(2).gameObject.SetActive(false);
                    player.transform.GetChild(1).gameObject.SetActive(false);
                    player.transform.GetChild(0).gameObject.SetActive(true);
                    player.transform.GetChild(0).gameObject.SetActive(true);
                    Debug.Log(player.transform.GetChild(0).GetChild(pa.avatar).gameObject.name);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(true);
                }
                if (scriptNorm.GetComponent<TrialArg1>().indexer == s.Length-1 && !(scriptWrongSpot.activeSelf))
                {
                    Debug.Log("CheckCheck");
                    
                    player.transform.GetChild(1).gameObject.SetActive(false);
                    player.transform.GetChild(2).gameObject.SetActive(true);
                    player.transform.GetChild(0).GetChild(pa.avatar).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(true);
                }
                talking(s[indexer]);
                indexer++;
            }
        }
        if (Input.GetKeyDown(KeyCode.W) && indexer < s.Length - 1 && !(scriptWrongSpot.activeSelf))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (correctLine == s[indexer - 1])
                {
                    correctLineApplied = true;

                    gameObjectie.transform.GetChild(1).gameObject.SetActive(true);
                    gameObjectie.transform.GetChild(0).gameObject.SetActive(false);
                    //SceneManager.LoadScene(sceneName: "InventoryTest");
                }
                else
                {
                    correctLineApplied = false;

                    gameObjectie.transform.GetChild(1).gameObject.SetActive(true);
                    gameObjectie.transform.GetChild(0).gameObject.SetActive(false);
                    //if (lives.GetComponent<PlayerHealth>().curr == 1)
                    //{
                    //    Debug.Log("Look Here");
                    //    lives.GetComponent<PlayerHealth>().handleHealth();
                    //}
                    //scriptNorm.SetActive(false);

                }
                indexer++;

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
