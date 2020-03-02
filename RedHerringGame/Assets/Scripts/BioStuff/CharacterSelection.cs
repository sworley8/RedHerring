using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] charList;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        charList = new GameObject[transform.childCount];
        for(int i = 0; i< transform.childCount; i++) {
            charList[i] = transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ToggleLeft();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ToggleRight();
        }
    }
    public void ToggleLeft()
    {
        
        charList[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = charList.Length - 1;
        }
        if (charList[index].gameObject.name == "CharacterList")
        {
            index--;
        }
        charList[index].SetActive(true);

    }
    public void ToggleRight()
    {
        
        charList[index].SetActive(false);
        index++;
        if (index > charList.Length - 1 || charList[index].gameObject.name == "CharacterList")
        {
            index = 0;
        }
        //if (charList[index].gameObject.name == "CharacterList")
        //{
        //    index++;
        //}

        charList[index].SetActive(true);
    }
}
