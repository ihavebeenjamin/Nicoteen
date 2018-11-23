using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Slider healthBar;
    public Text HPText;
    public PlayerHealthManager playerHealth;
    private PlayerStats thePlayerStats;
    public Text levelText;

    public Text LumberText;
    public Text MoneyText;

    private static bool HealthbarExists;
	// Use this for initialization
	void Start () {
        if (!HealthbarExists)
        {
            HealthbarExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        thePlayerStats = GetComponent<PlayerStats>();
    }
	
	// Update is called once per frame
	void Update () {
        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        HPText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;
        levelText.text = "LVL: " + thePlayerStats.currentLevel;

        LumberText.text = "" + thePlayerStats.currentLumber;
        MoneyText.text = "" + thePlayerStats.money;
        
 		
	}
}
