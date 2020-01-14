using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectItemForInventory : MonoBehaviour
{
    public List<GameObject> correctObjects = new List<GameObject>();
    private List<string> CorrectNames = new List<string>();
    
    public bool works = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < correctObjects.Count; i++)
        {
            if (!CorrectNames.Contains(correctObjects[i].name))
            {
                CorrectNames.Add(correctObjects[i].name);
                works = true;
            }
        }
        
    }
    public List<string> ReturnCorrectNames()
    {
        return CorrectNames;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
