using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectItem : MonoBehaviour
{
    private Text selectedText;
    private List<OneItem> myInventory;

    // Start is called before the first frame update
    void Start()
    {
        selectedText = GameObject.Find("DetailsText").GetComponent<Text>();
        CreateItem newvie = GameObject.FindGameObjectWithTag("creation").GetComponent<CreateItem>();
        myInventory = newvie.ReturnCorrectItems();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowSelectedText()
    {

        if (this.gameObject.GetComponent<Toggle>().isOn)
        {
            if (this.gameObject.name != "Empty")
            {
                if (this.gameObject.name == "Body")
                {
                    selectedText.text = "Item:" + myInventory[0].Id + " " + myInventory[0].Title + "                 " + myInventory[0].Description + "\n\n" + "Press the Spacebar to Present Evidence.";

                }
                if (this.gameObject.name == "Photo")
                {
                    Debug.Log(this.gameObject.name);
                    selectedText.text = "Item:" + myInventory[1].Id + " " + myInventory[1].Title + "                 " + myInventory[1].Description + "\n\n" + "Press the Spacebar to Present Evidence.";
                }
                if (this.gameObject.name == "Book")
                {
                    selectedText.text = "Item:" + myInventory[2].Id + " " + myInventory[2].Title + "                 " + myInventory[2].Description + "\n\n" + "Press the Spacebar to Present Evidence.";

                }
                if (this.gameObject.name == "Candlestick")
                {
                    Debug.Log(this.gameObject.name);
                    selectedText.text = "Item:" + myInventory[3].Id + " " + myInventory[3].Title + "                 " + myInventory[3].Description + "\n\n" + "Press the Spacebar to Present Evidence.";
                }
                if (this.gameObject.name == "Pentagram")
                {
                    selectedText.text = "Item:" + myInventory[4].Id + " " + myInventory[4].Title + "                 " + myInventory[4].Description + "\n\n" + "Press the Spacebar to Present Evidence.";

                }
                
                //this.gameObject.GetComponent<Toggle>().isOn = true;

            }
        }
    }
}
