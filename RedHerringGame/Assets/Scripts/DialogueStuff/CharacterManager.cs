using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager cm;
    public RectTransform characterBox;

    //All characters in scene
    public List<CharacterBasicInfo> characters = new List<CharacterBasicInfo>();
    //Lookup of characters in scene
    public Dictionary<string, int> charaDict = new Dictionary<string, int>();
    private void Awake()
    {
        cm = this;
    }

    public CharacterBasicInfo GetCharacters(string characterName, bool createChara = true)
    {
        int index = -1;
        if (charaDict.TryGetValue(characterName, out index))
        {
            return characters[index];
        } else if (createChara)
        {
            return createCharacters(characterName);
        }
        return null;
    }

    public CharacterBasicInfo createCharacters(string charName)
    {
        CharacterBasicInfo newbie = new CharacterBasicInfo(charName);
        charaDict.Add(charName, characters.Count);
        characters.Add(newbie);
        return newbie;
    }
    //Helpful for transitions and movement of characters
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
