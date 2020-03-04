using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButton : MonoBehaviour
{
    public PronounAndAvatar picking;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    public void changeNext()
    {
        if (picking.pronoun != "" && picking.avatar != 2)
        {
            SceneManager.LoadScene(sceneName: "TutorialIntroScene");
            //SceneManager.LoadScene(sceneName: "IntroScene");
        }
    }
}
