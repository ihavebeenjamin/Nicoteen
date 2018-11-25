﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour {

    public GameObject[] buildings;
    private BuildingPlacement buildingPlacement;
	// Use this for initialization
	void Start () {
        buildingPlacement = GetComponent<BuildingPlacement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI() 
    {
        for(int i = 0; i <buildings.Length; i++)
        {
            if (GUI.Button(new Rect(Screen.width - 120 , Screen.height/20 +Screen.height/12 *i, 100, 30), buildings[i].name))
            {
                buildingPlacement.SetItem(buildings[i]);
            }
        }
    }
}

