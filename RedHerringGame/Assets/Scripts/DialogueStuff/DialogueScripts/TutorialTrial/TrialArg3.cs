using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialArg3 : MonoBehaviour
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
        correctLine = "You would have already said my name. So, what is it? Well, I’m waiting.";


        indexer = 0;
        talking(s[indexer]);
        indexer++;


        //player = GameObject.FindGameObjectWithTag("Player");
    }
    //No, you’re not my friend! I would know if it’s you! I know them/her/him better than anyone in the world! - Occultist
    //Your friend pauses and it seems they/he/she is entertaining the thought that you might be you.
    //You don’t… If you were really Eviction/ Victoria/ Victor, you would have already said it.- Occultist
    //* You would have already said my name. So, what is it? Well, I’m waiting.- Occultist
    //I know you don’t know it.So, stop pretending to be Vic.- Occultist


    public string[] s = new string[]
    {
        "No, you’re not my friend! I would know if it’s you! I know them/her/him better than anyone in the world!:Occulist",
        "Your friend pauses and it seems they/he/she is entertaining the thought that you might be you.:NA",
        "You don’t… If you were really Eviction/ Victoria/ Victor, you would have already said it.:Occulist",
        "You would have already said my name. So, what is it? Well, I’m waiting.",
        "I know you don’t know it.So, stop pretending to be Vic."
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
            scriptWrong.GetComponent<TrialArg3>().indexer = 0;
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
                    //Debug.Log(scriptWrong.activeSelf);
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
                    Debug.Log(scriptWrong.GetComponent<TrialArg3>().indexer);
                    scriptWrong.SetActive(false);
                    scriptWrongSpot.SetActive(false);
                    scriptNorm.SetActive(true);
                    scriptNorm.GetComponent<TrialArg3>().indexer = 0;
                }
                if (indexer == s.Length - 1 && (scriptWrongSpot.activeSelf))
                {

                    //Debug.Log(scriptWrong.activeSelf);
                    player.transform.GetChild(2).gameObject.SetActive(false);
                    player.transform.GetChild(1).gameObject.SetActive(false);
                    player.transform.GetChild(0).gameObject.SetActive(true);
                    player.transform.GetChild(0).GetChild(pa.avatar).gameObject.SetActive(true);
                    Debug.Log(player.transform.GetChild(0).gameObject.name);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(true);
                }
                //if (scriptNorm.GetComponent<TrialArg3>().indexer == s.Length - 1 && !(scriptWrongSpot.activeSelf))
                //{
                //    Debug.Log("CheckCheck");

                //    player.transform.GetChild(1).gameObject.SetActive(false);
                //    player.transform.GetChild(2).gameObject.SetActive(false);
                //    player.transform.GetChild(0).gameObject.SetActive(true);
                //    player.transform.GetChild(0).GetChild(pa.avatar).gameObject.SetActive(true);
                //    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                //    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                //    dialogueBox.transform.GetChild(0).gameObject.SetActive(true);
                //}
                talking(s[indexer]);
                indexer++;
            }
        }
        if (Input.GetKeyDown(KeyCode.W) && indexer <= s.Length - 1 && !(scriptWrongSpot.activeSelf))
        {
            Debug.Log("CheckCheck");
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
