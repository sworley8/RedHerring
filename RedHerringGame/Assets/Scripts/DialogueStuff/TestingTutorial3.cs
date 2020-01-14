using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingTutorial3 : MonoBehaviour
{
    public CharacterBasicInfo StickMan;
    // Start is called before the first frame update
    void Start()
    {
        StickMan = CharacterManager.cm.GetCharacters("stick-figure-vector-clipart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
