using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform player;
    public CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint1 = GameObject.Find("Reset1").transform;
        spawnPoint2 = GameObject.Find("Reset2").transform;
        spawnPoint3 = GameObject.Find("Reset3").transform;
        player = GameObject.Find("Player").transform;
    }
    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Works");
        if (col.transform.tag == "Player" && this.transform.name == "Wrong1")
        {
            //Debug.Log(spawnPoint1.transform.position);
            cc.enabled = false;
            player.transform.position = spawnPoint1.transform.position;
            cc.enabled = true;
            Debug.Log(player.transform.position);
        }
        if (col.transform.tag == "Player" && this.transform.name == "Wrong2")
        {
            cc.enabled = false;
            col.transform.position = spawnPoint2.transform.position;
            cc.enabled = true;
            Debug.Log(player.transform.position);
        }
        if (col.transform.tag == "Player" && this.transform.name == "Wrong3")
        {
            cc.enabled = false;
            col.transform.position = spawnPoint3.transform.position;
            cc.enabled = true;
            Debug.Log(player.transform.position);
        }
        if (col.transform.tag == "Player" && this.transform.name == "End")
        {
            SceneManager.LoadScene(sceneName: "GameOverScene");
        }
    }
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
