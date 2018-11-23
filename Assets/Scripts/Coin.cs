using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
    public int moneyToAdd;
    private  PlayerStats playerStats;
    
    // Use this for initialization
    void Start () {
        playerStats = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerStats.AddMoney(moneyToAdd);
            Destroy(gameObject);
        }
    }
}
