using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trees : MonoBehaviour {
    public int MaxHealth;
    public int CurrentHealth;

    public float startTime;
    public float currentTime;
    public bool dead;

    

    private PlayerStats playerStats;
    private TreeSpawner TreeSpawner;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = MaxHealth;
        playerStats = FindObjectOfType<PlayerStats>();
        TreeSpawner = FindObjectOfType<TreeSpawner>();
        currentTime = startTime;
        dead = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            playerStats.AddLumber(Random.Range(1, 3));
            gameObject.SetActive(false);
            TreeSpawner.currentTrees -= 1;

        }

    }
    

    public void LoseHealth(int DamageToGive)
    {
        CurrentHealth -= DamageToGive;
    }

    
}
