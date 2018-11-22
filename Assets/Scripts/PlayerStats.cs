using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;

    public int currentExp;

    public int[] toLevelUp;

    public int currentLumber;
    
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (currentExp >= toLevelUp[currentLevel])
        {
            currentLevel++;
        }
		
	}
    public void AddExperience(int experienceToAdd)
    {
        currentExp += experienceToAdd;
    }

    public void AddLumber(int lumberToAdd)
    {
        currentLumber += lumberToAdd;
        currentExp += 20;
    }
}
