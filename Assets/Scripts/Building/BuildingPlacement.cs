using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacement : MonoBehaviour {

    private Transform currentBuilding;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if (currentBuilding != null)
       // {
        //    Vector3 m = Input.mousePosition;
       //     currentBuilding.position = new Vector3(m.x, m.y, 0);
       // }
	}
    public void SetItem(GameObject b)
    {
        currentBuilding = ((GameObject)Instantiate(b)).transform;
    }
}
