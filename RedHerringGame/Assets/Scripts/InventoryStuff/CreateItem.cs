using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    public List<string> maybeNames = new List<string>();
    public List<string> theirDescribes = new List<string>();
    public List<Sprite> theirImage = new List<Sprite>();
    private List<OneItem> inventory = new List<OneItem>();
    public List<bool> correctNameForLine = new List<bool>();
    
    // Start is called before the first frame update
    void Awake()
    {
        //maybeNames = cii.ReturnCorrectNames();
        for (int j = 0; j < maybeNames.Count; j++)
        {
            OneItem item = new OneItem();
            item.Title = maybeNames[j];
            item.Id = j;
            item.Description = theirDescribes[j];
            item.ItemPic = theirImage[j];



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
