using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PronounAndAvatar : MonoBehaviour
{
    public string pronoun;
    public int avatar;
    public GameObject playerchoice;
    void Awake()
    {
        DontDestroyOnLoad(playerchoice);
    }
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

}
