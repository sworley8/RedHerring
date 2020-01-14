using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    int maxHealth = 3;
    public GameObject lives;
    private int curr;

    // Start is called before the first frame update
    void Start()
    {
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
            SceneManager.LoadScene(sceneName: "InvestigationTest");
        }
        curr--;
        if (lives != null)
        {
            lives.transform.GetChild(maxHealth - (curr + 1)).gameObject.SetActive(false);
        }


    }
}
