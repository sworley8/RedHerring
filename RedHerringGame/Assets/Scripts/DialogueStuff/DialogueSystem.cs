using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public static DialogueSystem ds;
    public Info infos;
    private void Awake()
    {
        ds = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void talkingoverride(string scripts, string cName)
    {
        stopTalking();
        speaking = StartCoroutine(Speak(scripts, false, cName));
    }

    //public void talking(string scripts, string cName)
    //{
    //    stopTalking();
    //    script.text = speech;
    //    speaking = StartCoroutine(Speak(scripts, true, cName));
    //}
    public void stopTalking()
    {
        if (isSpeaking)
        {
            StopCoroutine(speaking);
        }
        speaking = null;
    }
    public bool isSpeaking { get { return speaking != null; } }
    public bool waitingForInput = false;
    public string speech = "";
    Coroutine speaking = null;

    IEnumerator Speak(string targetScript, bool adding, string characterN)
    {
        
        //dialogueBox.enabled = true;
        speech = targetScript;
        if (!adding)
        {
            script.text = "";
        } else
        {
            speech = script.text + speech;
        }

        speakerName.text = FigureOutCharacter(characterN);

        waitingForInput = false;
        while (script.text != targetScript)
        {
            script.text += targetScript[script.text.Length];
            yield return new WaitForEndOfFrame();
        }
        waitingForInput = true;
        while (waitingForInput)
        {
            yield return new WaitForEndOfFrame();
        }
        stopTalking();

    }
    string FigureOutCharacter(string s)
    {
        string finalVal = speakerName.text;
        if (s!= speakerName.text && s != "")
        {
            finalVal = (s.ToLower().Contains("narrator")) ? "" : s;
        }
        return finalVal;
    }
    [System.Serializable]
    public class Info
    {
        public Text speakerName;
        public Text script;
        //public Image dialogueBox;
        //public Sprite speakerImage;
        //public Sprite dialogueBoxImage;
    }
    public Text speakerName { get { return infos.speakerName; } }
    public Text script{ get { return infos.script;} }
    //public Image dialogueBox { get { return infos.dialogueBox; } }
    //public Sprite speakerImage;
    //public Sprite dialogueBoxImage;
}
