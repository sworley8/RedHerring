using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canScript : MonoBehaviour
{
    //    Can you ask about the candle?: Victor
    //Hey Soleis, humor me.Why is there a lit candle in your room; it isn’t allowed?: Kevin
    //Really? How stupid are you? You literally gave me this cheap thing as a gift, remember. You said you knew how much I love fire.I would never buy something as cheap as that: Soleis
    //I was out buying a new candle earlier today cause I had finished my $600 candle.Cheap things! None had the proper fire look at the stores.
    //Did she just say how much she loves fire not candles? And did she set candles on fire while in the store? How does she know that?: Victor
    //Some mysteries are best left unknown, right Soleis.: Kevin

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

    public string[] s = new string[]
    {

        "Can you ask about the candle?:Victor",
        "Humor me, please. Why is there a lit candle in your room; it isn’t allowed?: Kevin",
        "Really? How stupid are you? You literally gave me this cheap thing as a gift, remember.",
        "You said you knew how much I love fire.I would never buy something as cheap as that: Soleis",
        "I was out buying a new candle earlier today cause I had finished my $600 candle.Cheap things! None had the proper fire look at the stores.",
        "Did she just say how much she loves fire not candles? And did she set candles on fire while in the store? How does she know that?:Victor",
        "Some mysteries are best left unknown, right Soleis.:Kevin"
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
                if (indexer == 1)
                {
                    //Kevin
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);

                    characterArt.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);

                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                }
                else if (indexer == 2)
                {
                    //Soleis
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);

                    characterArt.transform.GetChild(2).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);

                    dialogueBox.transform.GetChild(2).gameObject.SetActive(true);
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
