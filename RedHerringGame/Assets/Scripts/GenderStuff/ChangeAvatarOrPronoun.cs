using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAvatarOrPronoun : MonoBehaviour
{
    public PronounAndAvatar picking;
    public Button bu;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    //public Image avatar1;
    //public GameObject male;
    //public GameObject male;
    //public GameObject male;
    //public GameObject male;

    public void changeToFemale()
    {
        if (picking.pronoun != "female")
        {
            //Debug.Log("1");
            picking.pronoun = "female";
        }
    }
    public void changeToMale()
    {
        if (picking.pronoun != "male")
        {
            //Debug.Log("2");
            picking.pronoun = "male";
        }
    }
    public void changeToNonBinary()
    {
        if (picking.pronoun != "nonbinary")
        {
            //Debug.Log("3");
            picking.pronoun = "nonbinary";
        }
    }
    public void changeAvatar1()
    {
        if (picking.avatar != 0)
        {
            //Debug.Log("0");
            picking.avatar = 0;
        }
        //Debug.Log("888");
    }
    public void changeAvatar2()
    {
        if (picking.avatar != 1)
        {
            //Debug.Log("999");
            picking.avatar = 1;
        }
        //Debug.Log("777");
    }
}
