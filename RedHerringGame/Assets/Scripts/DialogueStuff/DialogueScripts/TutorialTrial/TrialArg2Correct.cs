using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrialArg2Correct : MonoBehaviour
{

    DialogueSystem test;
    public int indexer;
    public GameObject dialogueBox;
    public GameObject characterArt;
    // Start is called before the first frame update
    void Start()
    {
        //test = DialogueSystem.instance;
        test = DialogueSystem.ds;
        indexer = 0;
        talking(s[indexer]);
        indexer++;
    }
//    This book that I found in the bathroom proves that some kind of ritual was going on in the bathroom- Vic
//The book was open to this specific page.In it the illustrations said that this ritual required candles, chalk drawing of a pentagram, and someone on the floor.- Vic
//You did this ritual to the body in the bathroom didn’t you?- Vic

//What? How did you find that?- Occultist
//Fine, I will admit it. I was trying to bring my friend back to life.- Occultist
//But it didn’t work; she/he/they aren’t alive and now the sky is purple- Occultist
//Wahhhhhhh(like waluigi)- Occultist

//C’mon, it’s me! I look exactly like myself.Well, what I used to look like. - Vic

    public string[] s = new string[]
    {
        "This book that I found in the bathroom proves that some kind of ritual was going on in the bathroom:Vic",
        "The book was open to this specific page.In it the illustrations said that this ritual required candles, chalk drawing of a pentagram, and someone on the floor.",
        "You did this ritual to the body in the bathroom didn’t you?",
        "What? How did you find that?:Occultist",
        "Fine, I will admit it. I was trying to bring my friend back to life.",
        "But it didn’t work; she/he/they aren’t alive and now the sky is purple.",
        "Wahhhhhhh(like waluigi)",
        "C’mon, it’s me! I look exactly like myself.Well, what I used to look like.:Vic"



    };
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Fire1"))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (indexer >= s.Length)
                {
                    SceneManager.LoadScene(sceneName: "TrialPart3Candle");
                }
                if (indexer == 4 || indexer == 5 || indexer == 6 || indexer == 3)
                {

                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                }
                else
                {
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);
                    characterArt.transform.GetChild(0).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(true);
                }

                talking(s[indexer]);
                indexer++;
            }
        }
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
