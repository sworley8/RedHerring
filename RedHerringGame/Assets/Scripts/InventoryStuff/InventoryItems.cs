using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryItems : MonoBehaviour
{
    public int startX;
    public int startY;
    public int slotsPerPage;
    public int slotLength;
    public GameObject slotPrefab;
    private int xPos;
    private int yPos;
    private GameObject slot;
    private int slotCount;
    public ToggleGroup tg;


    public List<GameObject> inventorySlots;
    public List<OneItem> myInventory;

    // Start is called before the first frame update
    void Start()
    {
        CreateInventorySlots();
        AddItemToTory();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateInventorySlots()
    {
        inventorySlots = new List<GameObject>();
        xPos = startX;
        yPos = startY;
        for (int i = 0; i < slotsPerPage; i++)
        {
            slot = (GameObject)Instantiate(slotPrefab);
            slot.name = "Empty";
            slot.GetComponent<Toggle>().group = tg;
            inventorySlots.Add(slot);

            slot.transform.SetParent(this.gameObject.transform);
            slot.GetComponent<RectTransform>().localPosition = new Vector3(xPos, yPos, 0);
            xPos += (int)slot.GetComponent<RectTransform>().rect.width;
            slotCount++;
            if (slotCount % slotLength == 0)
            {
                slotCount = 0;
                yPos -= (int)slot.GetComponent<RectTransform>().rect.width;
                xPos = startX;
            }
            



        }
    }
    private void AddItemToTory()
    {
        CreateItem newvie = GameObject.FindGameObjectWithTag("creation").GetComponent<CreateItem>();
        myInventory = newvie.ReturnCorrectItems();
        for (int j = 0; j < myInventory.Count; j++)
        {
            if (inventorySlots[j].name == "Empty")
            {
                inventorySlots[j].name = myInventory[j].Title;
            }
        }
    }

}
