using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialArg2 : MonoBehaviour
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
        scriptWrong = scriptWrongSpot.transform.GetChild(i).gameObject;
        lives = GameObject.FindGameObjectWithTag("Player");


    }
    void Start()
    {

        //scriptNorm = ra.scriptNorm;
        //test = DialogueSystem.instance;
        test = DialogueSystem.ds;
        correctLine = "You can’t prove that there was anything satanic occuring in the bathroom?";


        indexer = 0;
        talking(s[indexer]);
        indexer++;


        //player = GameObject.FindGameObjectWithTag("Player");
    }
    //Did you not know candles and pentagrams are always in this dorm’s bathroom?- Occultist
   // Can you even prove that they were not always in there? You can’t.I know you can’t- Occultist
   //* You can’t prove that there was anything satanic occuring in the bathroom?- Occultist
   // I don’t know anything about a satanic ritual- Occultist
   // Interesting.I’m pretty sure I can prove a ritual occured in the bathroom.- Vic


    public string[] s = new string[]
    {
        "Did you not know candles and pentagrams are always in this dorm’s bathroom?:Occulist",
        "Can you even prove that they were not always in there? You can’t.I know you can’t.",
        "You can’t prove that there was anything satanic occuring in the bathroom?",//correct line
        "I don’t know anything about a satanic ritual.",
        "Interesting.I’m pretty sure I can prove a ritual occured in the bathroom.:Victor",
    };

    // Update is called once per frame
    void Update()
    {

        dataInfo = GameObject.FindGameObjectWithTag("data").GetComponent<ToSeeIfPlayerRIght>().cameBackForMore;
        if (dataInfo)
        {
            GameObject.FindGameObjectWithTag("data").GetComponent<ToSeeIfPlayerRIght>().cameBackForMore = false;
            //lives.GetComponent<PlayerHealth>().handleHealth();
            scriptNorm.SetActive(false);
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
                if (indexer >= s.Length && !(scriptWrong.activeSelf))
                {
                    player.transform.GetChild(3).gameObject.SetActive(false);
                    player.transform.GetChild(pa.avatar).gameObject.SetActive(false);
                    player.transform.GetChild(2).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    indexer = 0;

                }
                if (indexer >= s.Length && (scriptWrong.activeSelf))
                {

                    player.transform.GetChild(2).gameObject.SetActive(true);
                    player.transform.GetChild(pa.avatar).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    lives.GetComponent<PlayerHealth>().handleHealth();
                    Debug.Log(scriptWrong.GetComponent<TrialArg1>().indexer);
                    scriptWrong.SetActive(false);
                    scriptNorm.SetActive(true);
                    scriptNorm.GetComponent<TrialArg1>().indexer = 0;
                }
                if (indexer == s.Length - 1 && (scriptWrong.activeSelf))
                {
                    Debug.Log("Hi");
                    player.transform.GetChild(2).gameObject.SetActive(false);
                    player.transform.GetChild(3).gameObject.SetActive(false);
                    player.transform.GetChild(pa.avatar).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(true);
                }
                if (indexer == s.Length - 1 && !(scriptWrong.activeSelf))
                {

                    player.transform.GetChild(2).gameObject.SetActive(false);
                    player.transform.GetChild(3).gameObject.SetActive(false);
                    player.transform.GetChild(pa.avatar).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(true);
                }
                talking(s[indexer]);
                indexer++;
            }
        }
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetButtonDown("Fire2")) && indexer <= s.Length - 1 && !(scriptWrong.activeSelf))
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
                    if (lives.GetComponent<PlayerHealth>().curr == 1)
                    {
                        Debug.Log("Look Here");
                        lives.GetComponent<PlayerHealth>().handleHealth();
                    }
                    scriptNorm.SetActive(false);

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
