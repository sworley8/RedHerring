using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneItem
{
    public int id;
    public string title;
    public string description;
    public Sprite itemPic;
    //public OneItem(int id, string name, string description, Sprite itemPic)
    //{
    //    this.id = id;
    //    this.title = name;
    //    this.description = description;
    //    this.itemPic = Resources.Load<Sprite>("ArtNAsset/" + title);
    //}

    public OneItem()
    {
        Title = "";
        Description = "";
        Id = 0;
        ItemPic = null;
    }
    public int Id { get { return id; } set { id = value; } }
    public string Title { get { return title; } set { title = value; } }
    public string Description { get { return description; } set { description = value; } }
    public Sprite ItemPic { get { return itemPic; } set { itemPic = value; } }
}


//public class OneItem : MonoBehaviour
//{


//    //// Start is called before the first frame update
//    //void Start()
//    //{

//    //}

//    //// Update is called once per frame
//    //void Update()
//    //{

//    //}
//}
