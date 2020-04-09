using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene : MonoBehaviour
{
    //public GameObject skip;
    public int start;
    //private void Awake()
    //{
    //    DontDestroyOnLoad(skip);
    //}
    // Start is called before the first frame update
    void Start()
    {
        //start = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) || Input.GetButtonDown("Fire2"))
        {

            SceneManager.LoadScene(start);
            //start++;
        }
    }
}
