using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolEnd : MonoBehaviour
{
    DialogueSystem test;
    public int indexer;
    public GameObject dialogueBox;
    public GameObject characterArt;
    public GameObject talker;
    //It was the day before yesterday.
    //My roommate had an exam to study for, but what other chance would we get to let off fireworks without getting caught.
    //The school decided to celebrate a home game win with a cookout near the stadium.
    //Soleis and I climbed up to the top of the closest building with her combustion project, axe spray and a lighter.
    //We used her makeshift flamethrower on her homemade fireworks to set them off in the sky.
    //It was totally awesome. Everyone just enjoyed the fireworks, thinking it was part of the event. That is until Soleis set one of them off in the direction of the dean’s car and set it on fire. I tried to stop her by grabbing the firework to change its direction, but it was too late and got terrible burns on both of my arms though. We quickly left and were never caught though. 
    ////// Start is called before the first frame update
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
        "Uggggggh. My head hurts.:Inner Thoughts",
        "Hey, ummm, who are we reviving again? Also, why?:???",
        "Seriously, why is he here?",
        "Come on, this is...."
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
