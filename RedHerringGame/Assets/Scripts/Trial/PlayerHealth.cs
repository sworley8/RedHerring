using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    int maxHealth = 3;
    public GameObject lives;
    public int curr;
    public GameObject thisData;

    // Start is called before the first frame update
    void Awake()
    {
        //DontDestroyOnLoad(thisData);
        curr = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            handleHealth();
        }
       
    }
    public void handleHealth()
    {
        if (curr == 0)
        {
            SceneManager.LoadScene(sceneName: "GameOverScene");
        }
        curr--;
        if (lives != null)
        {
            //Destroy(lives.transform.GetChild(maxHealth - (curr + 1)).gameObject);
            lives.transform.GetChild(maxHealth - (curr + 1)).gameObject.SetActive(false);
        }

    }
}
