using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
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
//    What is this? A flyer for a fireworks show?: Victor
//That feels like something I went to.Did I go with Soleis? I wish I remembered.: Victor


    public string[] s = new string[]
    {

        "What is this? A flyer for a fireworks show?:Victor",
        "That feels like something I went to.Did I go with Soleis? I wish I remembered."
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
