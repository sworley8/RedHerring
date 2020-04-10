using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyerScript : MonoBehaviour
{
    DialogueSystem test;
    public int indexer;
    public GameObject game;
    public GameObject dialogueBox;
    public GameObject characterArt;
    public ClickingActionFlash ca;
    // Start is called before the first frame update
    void Start()
    {
        //test = DialogueSystem.instance;
        test = DialogueSystem.ds;
        indexer = 0;
        talking(s[indexer]);
        indexer++;
    }
//    Is that your combustion project, Soleis?: Kevin
//Yup.Already tested it out and it is almost as perfect as me: Soleis
//What? You promised to test it out with me and Vic.: Soleis
//Vic said you didn’t want to come cause of some exam: Soleis
//I wish I remembered saying that.: Victor


    public string[] s = new string[]
    {

        "Is that your combustion project, Soleis?:Kevin",
        "Yup.Already tested it out and it is almost as perfect as me: Soleis",
        "What? You promised to test it out with me and Vic.",
        "Vic said you didn’t want to come cause of some exam.",
        "I wish I remembered saying that because you look mad that I did, Kevin.: Victor"
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
                    if (ca.numOfCorrectItemsNeed == 0)
                    {
                        ca.done = true;
                    }
                    game.SetActive(false);
                }
                if (indexer == 1 || indexer == 2 || indexer == 3)
                {
                    //sol
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);

                    characterArt.transform.GetChild(2).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);

                    dialogueBox.transform.GetChild(2).gameObject.SetActive(true);
                }
                else if (indexer == 0)
                {
                    //kevin
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);

                    characterArt.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);

                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                }
                else
                {
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);

                    characterArt.transform.GetChild(0).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);

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
