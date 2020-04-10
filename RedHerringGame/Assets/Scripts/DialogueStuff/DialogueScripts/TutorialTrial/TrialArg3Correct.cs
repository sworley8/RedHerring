using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrialArg3Correct : MonoBehaviour
{
    //How could I forget you, Knox/Karen/Kevin, my best friend in the whole world?- Vic


    //Is it really you? Did I really bring you back?- Knox/Karen/Kevin
    //No, I’m still dead and my memories are gone- Vic
    //We need to find my killer, and avenge my death- Vic
    //Will you help me solve my murder, Knox/Karen/Kevin?- Vic
    //If it really is you, then of course I will! Let’s solve your murder, together!- Knox/Karen/Kevin
    //Nice job, kid! You convinced Knox/Karen/Kevin to help you.Now find your murderer.You have until midnight to find them, and just so you know it is 12:01am right now.- Siri


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
        "How could I forget you, Knox/Karen/Kevin, my best friend in the whole world?:Vic",
        "Is it really you? Did I really bring you back?: Knox",
        "Kinda, I’m still dead and my memories are gone:Vic",
        "Will you help me solve my murder, Knox/Karen/Kevin?",
        "If it really is you, then of course I will! Let’s solve your murder, together!:Knox",
        "Nice job, kid! You convinced Knox/Karen/Kevin to help you.Now find your murderer.You have until midnight to find them, and just so you know it is 1201am right now.: Siri"



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
                    SceneManager.LoadScene(sceneName: "TBCScene");
                }
                if (indexer == 4 || indexer == 1)
                {

                    characterArt.transform.GetChild(0).gameObject.SetActive(false);
                    characterArt.transform.GetChild(2).gameObject.SetActive(false);
                    characterArt.transform.GetChild(1).gameObject.SetActive(true);
                    dialogueBox.transform.GetChild(0).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(2).gameObject.SetActive(false);
                    dialogueBox.transform.GetChild(1).gameObject.SetActive(true);
                }
                else if (indexer == 5)
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
