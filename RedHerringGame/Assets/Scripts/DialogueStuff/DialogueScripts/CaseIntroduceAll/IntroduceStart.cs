using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroduceStart : MonoBehaviour
{
//    I pick up the photo on my bed.: NA
//It’s a photo of me with everyone.We look happy.: Victor
//My classmates all look so...eccentric.
//So, you really don’t remember anyone?: Kevin
//No, Siri took them away: Victor
//What? Siri, like the phone assistant thing?: Kevin
//Yeah, she’s the ruler of this dimension: Victor
//Ummmmm. What?: Kevin
//You know what, Nevermind.Let me explain about the ritual.
//So, the ritual was a revival ritual of the recently dead. 
//So you were trying to revive me via satanic rituals? And you thought it would work? Have you seen any horror films? That never goes well.: Victor
//Well I mean… I was desperate.: Kevin
//Anyways, it’s like you said. You need a candle, a pentagram, and everyone, who last talked to the dead. The ritual must be said by someone without guilt in their heart about the deceased.
//You mean this is your alibi of why you didn’t kill me right? That is what you are getting at isn’t it.: Victor
//Waaaaaaah! It really is you.You always were so quick to understand my intentions.I really have missed you.: Kevin
//Kevin then tried to hug you, a little too hard in your opinion. He keeps grabbing at the air; seemingly forgetting you are a ghost.:NA
//Ok, you said you included people, who last talked to me.Who were they?: Victor
//Kevin scratches his head.Somehow you know that’s not a good sign: NA
//Here is the thing. I don’t know. I sent a message in the building groupchat that if you talked to Vic in the past day to come to my room. The bathroom lights were off to help set the mood, and you know our room’s lights are broken.: Kevin
//What is that a hazard to have broken lights in a dorm?:Victor
//I actually preferred it, and the maintenance hates you because of past offenses.So, really there isn’t a way to get it fixed.Anyways, the only person I know for certain, who was there was Solesis, the local head diva: Kevin
//Fine, I’m sure she has some information about this.If we can figure out the order of events after the murder, maybe we can figure out who did it.: Victor

   DialogueSystem test;
    public int indexer;
    public GameObject dialogueBox;
    public GameObject characterArt;
    public GameObject talker;
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
        "I pick up the photo on my bed.:NA",
        "It’s a photo of me with everyone.We look happy.: Victor",
        "My classmates all look so...eccentric.",
        "So, you really don’t remember anyone?:Kevin",
        "No, Siri took them away:Victor",
        "What? Siri, like the phone assistant thing?:Kevin",
        "Yeah, she’s the ruler of this dimension:Victor",
        "Ummmmm. What?:Kevin",
        "You know what, Nevermind.Let me explain about the ritual",
        "So, the ritual was a revival ritual of the recently dead.",
        "You were trying to revive me via satanic rituals? And you thought it would work? Have you seen any horror films? That never goes well.:Victor",
        "Well I mean… I was desperate.:Kevin",
        "Anyways, it’s like you said. You need a candle, a pentagram, and everyone, who last talked to the dead. The ritual must be said by someone without guilt in their heart about the deceased.",
        "You mean this is your alibi of why you didn’t kill me right? That is what you are getting at isn’t it.:Victor",
        "Waaaaaaah! It really is you.You always were so quick to understand my intentions.I really have missed you.:Kevin",
        "Kevin then tried to hug you, a little too hard in your opinion. He keeps grabbing at the air; seemingly forgetting you are a ghost.:NA",
        "Ok, you said you included people, who last talked to me.Who were they?:Victor",
        "Kevin scratches his head.Somehow you know that’s not a good sign:NA",
        "Here is the thing. I don’t know. I sent a message in the building groupchat that if you talked to Vic in the past day to come to my room. The bathroom lights were off to help set the mood, and you know our room’s lights are broken.:Kevin",
        "What is that a hazard to have broken lights in a dorm?:Victor",
        "I actually preferred it, and the maintenance hates you because of past offenses.So, really there isn’t a way to get it fixed.Anyways, the only person I know for certain, who was there was Solesis, the local head diva: Kevin:Kevin",
        "Fine, I’m sure she has some information about this.If we can figure out the order of events after the murder, maybe we can figure out who did it.: Victor"

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
                    talker.SetActive(false);
                }
                if (indexer == 3 || indexer == 5 || indexer == 7 || indexer == 8 || indexer == 9 || indexer == 11 || indexer == 12 || indexer == 14 || indexer == 18 || indexer == 20)
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
