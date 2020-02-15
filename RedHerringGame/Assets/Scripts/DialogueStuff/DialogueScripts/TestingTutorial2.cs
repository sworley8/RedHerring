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
    public GameObject player;
    public int indexer;
    public bool dataInfo;
    public GameObject lives;
    public GameObject gameObjectie;
    public GameObject dialogueBox;

    // Start is called before the first frame update
    private void Awake()
    {
        
        lives = GameObject.FindGameObjectWithTag("Player");

        
    }
    void Start()
    {

        //test = DialogueSystem.instance;
        test = DialogueSystem.ds;
        
        
        indexer = 0;
        talking(s[indexer]);
        indexer++;


        //player = GameObject.FindGameObjectWithTag("Player");
    }
    public string[] s = new string[]
    {
        "Wow, you caught on quick.:Sophia",
        "Let's play 2 truths and a lie. Press W to pull up the inventory screen to show I am lying.",
        "I told you to press the Cube",
        "My name is Sophia, and I programmed this game.",
        "And my last one is you are playing Red Herring.",
        "Hmmmm, which one is the lie: Hero"
    };
    public string[] x = new string[]
    {
        "You lose"
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
        if (Input.GetKeyDown(KeyCode.S))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (indexer >= s.Length && !(scriptWrong.activeSelf))
                {
                    player.transform.GetChild(1).gameObject.SetActive(false);
                    player.transform.GetChild(0).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(true);
                    indexer = 0;
                    
                }
                if (indexer >= s.Length && (scriptWrong.activeSelf))
                {
                    lives.GetComponent<PlayerHealth>().handleHealth();
                    scriptWrong.SetActive(false);
                    scriptNorm.SetActive(true);
                    scriptNorm.GetComponent<TestingTutorial2>().indexer = 0;
                }
                if (indexer == s.Length - 1 && !(scriptWrong.activeSelf))
                {
                    player.transform.GetChild(0).gameObject.SetActive(false);
                    player.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                }
                talking(s[indexer]);
                indexer++;
            }
        }
        if (Input.GetKeyDown(KeyCode.W) && indexer <= s.Length-1 && !(scriptWrong.activeSelf))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (correctLine == s[indexer-1])
                {
                    correctLineApplied = true;
                    gameObjectie.transform.GetChild(1).gameObject.SetActive(true);
                    gameObjectie.transform.GetChild(0).gameObject.SetActive(false);
                    //SceneManager.LoadScene(sceneName: "InventoryTest");
                }
                else {
                    correctLineApplied = false;
                    if (lives.GetComponent<PlayerHealth>().curr == 1)
                    {
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
