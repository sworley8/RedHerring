using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour
{

    public Transform target; //the enemy's target
    public int moveSpeed = 5; //move speed
    public int rotationSpeed = 10; //speed of turning
    public float range =20f; //Range within target will be detected
    public float stop =0;
    public timer t;
    public Transform myTransform; //current transform data of this enemy
    void Awake()
    {
        target = GameObject.FindWithTag("Player").transform; //target the player
        myTransform = transform; //cache transform data for easy access/preformance
    }
    void Update()
    {    //rotate to look at the player
        var distance = Vector3.Distance(myTransform.position, target.position);
        if (distance <= range)
        {
            //look
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
            Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
            //move
            if (distance > stop)
            {
                myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
            }
            if (t.t <= 60.0f)
            {
                myTransform.position += 2 * myTransform.forward * moveSpeed * Time.deltaTime;
            }
        }
    }
    //public Transform spawnPoint1;
    //public Transform player;
    //public CharacterController cc;
    //void OnTriggerEnter(Collider col)
    //{
    //    //Debug.Log("Works");
    //    if (col.transform.tag == "Player")
    //    {
    //        //Debug.Log(spawnPoint1.transform.position);
    //        cc.enabled = false;
    //        player.transform.position = spawnPoint1.transform.position;
    //        cc.enabled = true;
    //        Debug.Log(player.transform.position);
    //    }
    //}






    //public Transform Player;
    //int MoveSpeed = 4;
    //int MaxDist = 10;
    //int MinDist = 5;
    //public timer t;

    //void Start()
    //{

    //}

    //void Update()
    //{
    //    transform.LookAt(Player);

    //    if (Vector3.Distance(transform.position, Player.position) >= MinDist)
    //    {

    //        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    //        if (time.text)



    //        if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
    //        {
    //            //Here Call any function U want Like Shoot at here or something
    //        }

    //    }
    //}
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
