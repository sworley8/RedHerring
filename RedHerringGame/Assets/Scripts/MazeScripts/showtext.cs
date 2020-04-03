using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showtext : MonoBehaviour
{
    public GameObject uitext;
    // Start is called before the first frame update
    void Start()
    {
        uitext.SetActive(false);
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            uitext.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        uitext.SetActive(false);
        //gameObject.SetActive(false);
        //if (gameObject.name != "Directions" || )
        //Destroy(uitext);
        //Destroy(gameObject);

    }
}
