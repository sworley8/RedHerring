using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text time;
    public float startTime = 120.0f;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        //time.text;
    }

    // Update is called once per frame
    void Update()
    {
        t = startTime - Time.time;
        if (t <= 0.0)
        {
            SceneManager.LoadScene(sceneName: "GameOverScene");
        }
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        time.text = minutes + ":" + seconds;
    }
}
