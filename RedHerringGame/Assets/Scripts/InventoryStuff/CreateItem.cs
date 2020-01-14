using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    public List<string> maybeNames;
    private List<OneItem> inventory;
    
    // Start is called before the first frame update
    void Start()
    {
        //maybeNames = cii.ReturnCorrectNames();
        for (int j = 0; j < maybeNames.Count; j++)
        {
            OneItem item = new OneItem();
            item.Title. = maybeNames[j];
            item.Id = j;
            inventory.Add(item);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public List<OneItem> ReturnCorrectItems()
    {
        return inventory;
    }
}
