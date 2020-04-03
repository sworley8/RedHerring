using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookScript : MonoBehaviour
{
    DialogueSystem test;
    public int indexer;
    public GameObject game;
    public ClickingActionTutorialProcess ca;
    // Start is called before the first frame update
    void Start()
    {
        //test = DialogueSystem.instance;
        test = DialogueSystem.ds;
        indexer = 0;
        talking(s[indexer]);
        indexer++;
    }
//    The book is opened to a ritual that reads “Vivifica Spirituum Qui Pereunt”.- Vic
//I don't know what that means, but the illustrations make it look like this ritual requires candles, chalk drawing, and those who have recently talked to the dead. Looks like they have items in their hands and there’s someone on the floor?- Vic
//Maybe that crying person from earlier would know more about this?- Vic
    public string[] s = new string[]
    {

        "The book is opened to a ritual that reads “Vivifica Spirituum Qui Pereunt”.: Vic",
        "I don't know what that means, but the illustrations make it look like this ritual requires candles, chalk drawing, and those who have recently talked to the dead.",
        "Looks like they have items in their hands and there’s someone on the floor? Maybe that crying person from earlier would know more about this?"
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
