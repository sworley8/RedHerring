using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialTrialScript1 : MonoBehaviour
{
    DialogueSystem test;
    public GameObject scriptNorm;
    public GameObject scriptWrong;
    
    // Start is called before the first frame update
    void Start()
    {
        //test = DialogueSystem.instance;
        test = DialogueSystem.ds;
    }
    public string[] s = new string[]
    {
        "Well I guess this is it:Hero",
        "Here I stand bare for all to see",
        "I will, NO I must kill them all!",
        "Lets try one more line"
    };
    int indexer = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                if (indexer >= s.Length)
                {
                    scriptNorm.SetActive(true);
                    scriptWrong.SetActive(false);
                    return;
                }
                talking(s[indexer]);
                indexer++;
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //if (!test.isSpeaking || test.isWaitingForUserInput)
            if (!test.isSpeaking || test.waitingForInput)
            {
                SceneManager.LoadScene(sceneName: "InvestigationTest");
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            scriptNorm.SetActive(true);
            scriptWrong.SetActive(false);
            //scriptWrong.SetActive(true);
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
