using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class CharacterBasicInfo : MonoBehaviour
{
    public string nameBoi;
    //container for all images
    public GameObject root;
    public CharacterBasicInfo (string namey)
    {
        CharacterManager instance = CharacterManager.cm;
        GameObject prefab = Resources.Load("ArtNAsset/Character[" + namey + "]") as GameObject;
        GameObject ob = Instantiate(prefab, instance.characterBox);


        root = ob.GetComponent<GameObject>();
        nameBoi = namey;

        renderers.singleLayerImage = ob.GetComponentInChildren<Image>();
    }
    class RenderersBoi
    {
        public Image singleLayerImage;
        //if need or want multilayer can put in here
    }
    RenderersBoi renderers = new RenderersBoi();
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
