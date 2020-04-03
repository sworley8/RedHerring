using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrialIntro : MonoBehaviour
{
    //    Waaaaaah! It’s..it’s you.- Occultist
    //You...You aren’t real. Nope, no- Occultist

    //Hey! I am very real!- Vic

    //Hmm, did I erase all your memories or just mess with your short term memory? Oh well.I already told you, you need to convince him/her/they that you are real.- Siri
    //Well, how am I supposed to do that? He/She/They have/has only yelled and cried since I’ve woken up- Vic

    //Remember everything you saw in the bathroom? I would start with that.- Siri

    //If you hear something that contradicts what you found in the bathroom, pull up the inventory screen (which is where all the clues are) with the W keyboard button.- Siri

    //Why are you just staring down? Oh gosh, it doesn’t matter.You aren’t real!- Occultist

    //Of course it’s me! You performed a ritual to bring me back, right? -Vic


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
    public string[] s = new string[]
    {
        "Waaaaaah! It’s..it’s you.:Crying Person",
        "You...You aren’t real. Nope, no",
        "Hey! I am very real!:Vic",
        "Hmm, did I erase all your memories or just mess with your short term memory? Oh well. I already told you, you need to convince him/her/they that you are real.:Siri",
        "Well, how am I supposed to do that? He/She/They have/has only yelled and cried since I’ve woken up:Vic",
        "Remember everything you saw in the bathroom? I would start with that.: Siri",
        "If you hear something that contradicts what you found in the bathroom, pull up the inventory screen (which is where all the clues are) with the W keyboard button.",
        "Why are you just staring down? Oh gosh, it doesn’t matter.You aren’t real!:Crying Person",
        "Of course I am. You performed a ritual to bring me back, right?: Victor"
        
    };
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Fire1"))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (indexer == 0 || indexer == 1 || indexer == 7)
                {

                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                }
                else if (indexer == 3 || indexer == 5 || indexer == 6)
                {
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(true);
                }
                else
                {
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);
                    characterArt.transform.GetChild(0).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(true);
                }
                if (indexer >= s.Length)
                {
                    SceneManager.LoadScene(sceneName: "TrialPart1Photo");
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
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
