using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvestigateStart : MonoBehaviour
{
    //    *GASP* A dead body! Who set the bathroom up like a crime scene?-Vic
    //  ** The body looks like me! There is no mistaking my face.-Vic
    //   ** I’m dead? Oh gosh I really did die! But how?-Vic
    //      Wonderful, I see you found yourself! Relax, it’s just your corpse. Being dead must be hell on the brain. Did you forget I took your memories?- Siri
    //Now, take a look around the room to find proof that you are who you think you are.- Siri
    //      And how exactly am I supposed to do that?- Vic

    //** It’s too late Siri has already disappeared.I guess I have to figure it out on my own.

    DialogueSystem test;
    public int indexer;
    public GameObject dialogueBox;
    public GameObject characterArt;
    //public new GameObject gameObject;
    //public new GameObject gameObject2;
    public string[] s = new string[]
    {
        "*GASP* A dead body! Who set the bathroom up like a crime scene?:Vic",
        "The body looks like me! There is no mistaking my face.",
        "I’m dead? Oh gosh I really did die! But how?",
        "Wonderful, I see you found yourself! Relax, it’s just your corpse. Being dead must be hell on the brain. Did you forget I took your memories?:Siri",
        "Now, take a look around the room to find proof that you are who you think you are.",
        "And how exactly am I supposed to do that?:Vic",
        "It’s too late Siri has already disappeared.I guess I have to figure it out on my own.:NA"

    };

    // Start is called before the first frame update
    void Start()
    {
        test = DialogueSystem.ds;
        indexer = 0;
        talking(s[indexer]);
        indexer++;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown("Fire1"))
        {
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (indexer >= s.Length)
                {
                    SceneManager.LoadScene(sceneName: "BathroomScene2");
                }

                talking(s[indexer]);
                indexer++;
            }
            if (indexer == 4 || indexer == 5)
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
