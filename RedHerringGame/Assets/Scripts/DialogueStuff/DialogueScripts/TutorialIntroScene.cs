using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialIntroScene : MonoBehaviour
{
    DialogueSystem test;
    public int indexer;
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
        "Hello, Hello, Testing 1,2,3.....Ah! Now I see you.:Sophia",
        "Do you think you can do me a favor?",
        "Press the sphere for me in the next room.",
        "You'll know you succeed when you see my pretty face again. Oh, a hint press the capsule first."
    };
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
                    SceneManager.LoadScene(sceneName: "TutorialInvestigationScene");
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
