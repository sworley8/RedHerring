using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPlayerChoice : MonoBehaviour
{
    public PronounAndAvatar picking;
    public GameObject dialoguespot;
    public GameObject playerspot;
    public GameObject cultspot;
    // Start is called before the first frame update
    void Start()
    {
        picking = (PronounAndAvatar)GameObject.FindObjectOfType(typeof(PronounAndAvatar));
        if (picking.pronoun == "male")
        {
            //Debug.Log("67");
            dialoguespot.transform.GetChild(2).gameObject.SetActive(false);
            dialoguespot.transform.GetChild(1).gameObject.SetActive(false);
            dialoguespot.transform.GetChild(0).gameObject.SetActive(true);

        }
        if (picking.pronoun == "female")
        {
            //Debug.Log("678");
            dialoguespot.transform.GetChild(2).gameObject.SetActive(false);
            dialoguespot.transform.GetChild(0).gameObject.SetActive(false);
            dialoguespot.transform.GetChild(1).gameObject.SetActive(true);
        }
        if (picking.pronoun == "nonbinary")
        {
            //Debug.Log("567");
            dialoguespot.transform.GetChild(1).gameObject.SetActive(false);
            dialoguespot.transform.GetChild(0).gameObject.SetActive(false);
            dialoguespot.transform.GetChild(2).gameObject.SetActive(true);
        }
        if (picking.avatar == 0)
        {
            //Debug.Log("9");
            playerspot.transform.GetChild(1).gameObject.SetActive(false);
            playerspot.transform.GetChild(0).gameObject.SetActive(true);
            cultspot.transform.GetChild(1).gameObject.SetActive(false);
            cultspot.transform.GetChild(0).gameObject.SetActive(true);

        }
        if (picking.avatar == 1)
        {
            //Debug.Log("5");
            playerspot.transform.GetChild(0).gameObject.SetActive(false);
            playerspot.transform.GetChild(1).gameObject.SetActive(true);
            cultspot.transform.GetChild(0).gameObject.SetActive(false);
            cultspot.transform.GetChild(1).gameObject.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
