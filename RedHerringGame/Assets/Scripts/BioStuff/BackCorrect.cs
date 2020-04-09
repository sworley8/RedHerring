using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackCorrect : MonoBehaviour
{
    public GameObject inventory;
    public GameObject map;
    public GameObject bio;
    public GameObject set;
    public GameObject app;
    public void backBaby()
    {
        if (name != app.name)
        {
            app.SetActive(true);
            inventory.SetActive(false);
            map.SetActive(false);
            bio.SetActive(false);
            set.SetActive(false);
            app.SetActive(false);

        }
    }
}
