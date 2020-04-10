using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolIntro : MonoBehaviour
{
    //    Oh my god, Kevin! Did you, like, need more help? Cause I would need to start charging for all of these good deeds I’m doing for the poor weakling like you.: Soleis
    //Wow, she seems like a lot, even to me and that’s saying something: Siri
    //Well I mean I do have some questions to ask you.But you know I’m not weak right, I just don’t exercise like you. I’m actually pretty strong for my size.: Kevin
    //Yeah, whatever.Since I guess I, like, hurt your pride or whatever, I'll let you into my room to talk. The hallway is too dirty anyways for me to breathe in for too long.: Soleis
    //Ask her about the ritual to see if it jogs her memory about anything strange that happened: Victor
    //And why can’t you ask her? She can probably hear you.: Kevin
    //Who are you talking to? Are you, like, going insane or something cause that’s, like, not cool.: Soleis
    //I see.Ok, then.What do you remember from the ritual earlier today?: Kevin
    //Well I remember you saying strange words and wanting to set the body on fire the whole time.That’s about it.Why?: Soleis
    //She was going to do what to my body? Excuse me what? ask her about that right now.: Victor
    //Look I know how close you were with Vic. If you, umm, well...need something, my door is open: Soleis
    //Thanks Soleis; I appreciate it.Do you think I can stay here for a bit?: Kevin
    //Yeah well pretty sure if I didn’t let you, you’d, like, do something stupid so yeah.: Soleis
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
        "Oh my god, Kevin! Did you, like, need more help? Cause I would need to start charging for all of these good deeds I’m doing for the poor weakling like you.:Soleis",
        "Wow, she seems like a lot, even to me and that’s saying something: Siri",
        "Well I mean I do have some questions to ask you.But you know I’m not weak right, I just don’t exercise like you. I’m actually pretty strong for my size.:Kevin",
        "Yeah, whatever.Since I guess I, like, hurt your pride or whatever, I'll let you into my room to talk. The hallway is too dirty anyways for me to breathe in for too long.:Soleis",
        "Ask her about the ritual to see if it jogs her memory about anything strange that happened:Victor",
        "And why can’t you ask her? She can probably hear you.:Kevin",
        "Who are you talking to? Are you, like, going insane or something cause that’s, like, not cool.:Soleis",
        "I see. Ok, then.What do you remember from the ritual earlier today?:Kevin",
        "Well I remember you saying strange words and me wanting to set the body on fire the whole time.That’s about it.Why?:Soleis",
        "She was going to do what to my body? Excuse me what? Ask her about that right now!:Victor",
        "Look I know how close you were with Vic. If you, umm, well...need something, my door is open:Soleis",
        "Thanks Soleis; I appreciate it.Do you think I can stay here for a bit?:Kevin",
        "Yeah well pretty sure if I didn’t let you, you’d, like, do something stupid so yeah.:Soleis"

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
                if (indexer == 2 || indexer == 0 || indexer == 5 || indexer == 7 || indexer == 11)
                {
                    //Kevin
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);
                    characterArt.transform.GetChild(3).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(3).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                }
                else if (indexer == 3 || indexer == 6 || indexer == 8 || indexer == 10 || indexer == 12)
                {
                    //Soleis
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);
                    characterArt.transform.GetChild(3).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(3).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(true);
                }
                else if (indexer == 1)
                {
                    //Siri
                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);
                    characterArt.transform.GetChild(3).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(3).gameObject.SetActive(true);
                }

                else
                {
                    characterArt.transform.GetChild(1).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);
                    characterArt.transform.GetChild(3).gameObject.SetActive(false);
                    characterArt.transform.GetChild(0).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(3).gameObject.SetActive(false);
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
