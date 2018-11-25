using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacement : MonoBehaviour {

    private PlaceableBuilding placeableBuilding;
    // private Transform currentBuilding;
    private GameObject selectedBuild;
    private bool hasPlaced;
    	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (selectedBuild != null && !hasPlaced)
       {
           Vector2 m = Input.mousePosition;
            
            selectedBuild.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(isLegalPosition());
                if (isLegalPosition())
                {
                    
                    hasPlaced = true;
                }
            }
        }
	}

    bool isLegalPosition()
    {
        
        if (placeableBuilding.collideCounter > 0)
        {
          return false;
        }
        return true;
    }
    public void SetItem(GameObject b)
    {
        hasPlaced = false;
        selectedBuild = Instantiate(b, Input.mousePosition, transform.rotation);
        placeableBuilding = selectedBuild.GetComponent<PlaceableBuilding>();
        Debug.Log(selectedBuild);
    }
}
