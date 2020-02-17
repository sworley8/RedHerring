﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class QuickTravelViaMap : MonoBehaviour
{

    public void NextScene()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        //Debug.Log(name);
        SceneManager.LoadScene(name);
    }
}
