using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHealth;
    public GameObject coin;
    private PlayerStats thePlayerStats;

    public int expToGive;
    // Use this for initialization
    void Start()
    {
        CurrentHealth = MaxHealth;
        thePlayerStats = FindObjectOfType<PlayerStats>();

       
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
           Instantiate(coin, transform.position, transform.rotation);
            Destroy(gameObject);

            thePlayerStats.AddExperience(expToGive);
        }

    }
    public void HurtEnemy(int damageToGive)
    {
       CurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
       CurrentHealth = MaxHealth;
    }
}
