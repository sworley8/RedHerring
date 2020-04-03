using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene1 : MonoBehaviour
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
    public string[] s = new string[]
    {
        "Where is this purple light coming from?:Inner Thoughts",
        "Wait, who is crying right now? They sound close. Are they ok?",
        "Right as I’m about to ask if they were ok?:NA",
        "Wahhhhhhh:Crying Person",
        "Oh chocolate fudge, its a ghost oh nooo",
        "Really?! Do they look scary?: Victor",
        "You are not real! You are not here! Oh man I really messed things up this time.:Crying Person",
        "Phone rings:NA",
        "Do you hear that ringing?: Victor",
        "Waaahh! It’s probably leading you towards the light! Now go please leave me alone!:Crying Person",
        "Where is that coming from? Weird that they haven’t heard that ringing yet.:Inner Thoughts",
        "I looked around for the phone and found it in my back pocket.:NA",
        "Where did this phone come from? Should I even answer it? Well….here goes nothing.:Inner Thoughts",
        "An unfamiliar feminine voice comes through the speaker.:NA",
        "It’s friendly and sounds young but echoes with untold millennia. Amusement barely hides menace..:NA",
        "Hello? Hello? Testing 1,2,3.....Ah! I think it’s working now.:???",
        "Hello! My name is hard to say, so let's just go with Siri.:Siri",
        "So, your friend over there botched a ritual and now you’ve fallen into my domain.",
        "I am the ruler of this place, the space between life and death. In a way.",
        "There is a smile in Siri’s voice and it’s ominous.:NA",
        "Due to you being dead and stuck here with me, you’re the only one who can hear me. For now. It’s more fun this way. We can keep secrets and tell stories.:Siri",
        "You can tell the secrets and stories she wants to tell are not happy ones. There’s no chill in the air but, somehow, you shiver.:NA",
        "But, let’s get to the fun stuff. You’re dead and your memories are gone. Poof. Nada. Non-existent!. I may or may not have taken them but they are gone!:Siri",
        "What?! No, that can’t be true!:Victor",
        "That slobbering mess in the corner is your ticket to getting all your precious memories back. Find a way to make them stop freaking out so you can get started.:Siri",
        "Here’s two hints- Find a way to make them/him/her not scared of you and find your body.",
        "You can click on objects to investigate and press E to pull up the map.",
        "See you next time.:Siri"
    };
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Fire1"))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (indexer == 3 || indexer == 4 || indexer == 6 || indexer == 9)
                {
                    
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                }
                else if (indexer == 15 || indexer == 16 || indexer == 17 || indexer == 18 || indexer == 20 || indexer == 21 || indexer == 22 || indexer == 24 || indexer == 25 || indexer == 26 || indexer == 27)
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
                    SceneManager.LoadScene(sceneName: "RoomIntro");
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
