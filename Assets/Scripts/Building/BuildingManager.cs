using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour {

    public GameObject building;
    private BuildingPlacement buildingPlacement;
	//// Use this for initialization
	//void Start () {
 //       buildingPlacement = GetComponent<BuildingPlacement>();
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
    public void  SelectBuilding () 
    {
      //  Debug.Log(building);
      buildingPlacement.SetItem(building);
                   
    }
}

