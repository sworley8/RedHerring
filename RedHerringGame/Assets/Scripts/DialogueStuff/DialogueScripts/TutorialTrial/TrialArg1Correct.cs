using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrialArg1Correct : MonoBehaviour
{
    //    It’s us! See.We were - we are friends. -Vic

    //How’d you find that picture? - Occultist
    //Looks at picture thoughtfully

    //It was in the bathroom.With the candle, the very nice satanic pentagram, and my body? It looks kinda like a demonic spa day? - Vic

    //Demonic spa day? What are you talking about? That is what any bathroom looks like.- Occultist

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
        "It’s us! See.We were - we are friends.:Vic",
        "How’d you find that picture?: Occultist",
        "He/She/They look at picture thoughtfully:NA",
        "It was in the bathroom.With the candle, the very nice satanic pentagram, and my body? It looks kinda like a demonic spa day?:Vic",
        "Demonic spa day? What are you talking about? That is what any bathroom looks like.: Occultist"



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
                    SceneManager.LoadScene(sceneName: "TrialPart2Book");
                }
                if (indexer == 4 || indexer == 1)
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
