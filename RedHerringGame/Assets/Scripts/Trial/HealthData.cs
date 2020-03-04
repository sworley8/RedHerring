using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthData : MonoBehaviour
{
    int maxHealth = 3;
    public int curr;
    public PlayerHealth pH;
    public GameObject thisData;
    void Awake()
    {
        DontDestroyOnLoad(thisData);
        curr = maxHealth;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curr = pH.curr;
        if (pH == null)
        {
            pH = (PlayerHealth)FindObjectOfType(typeof(PlayerHealth));
            while (curr < pH.curr)
            {
                pH.handleHealth();
            }
        } 
    }
}
