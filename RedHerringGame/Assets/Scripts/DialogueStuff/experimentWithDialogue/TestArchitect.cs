using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestArchitect : MonoBehaviour
{
    public Text text;
    TextArchitect architect;
    [TextArea(5, 10)]
    public string say;
    public int characterPerFrame = 1;
    public float speed = 1f;
    public bool useEncap = true;
    // Start is called before the first frame update
    void Start()
    {
        architect = new TextArchitect(say);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            architect = new TextArchitect(say, "", characterPerFrame, speed, useEncap);
        }
        text.text = architect.currentText;
    }
}
