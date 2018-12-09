using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacement : MonoBehaviour {

    private PlaceableBuilding placeableBuilding;
    // private Transform currentBuilding;
    private GameObject selectedBuild;
    private bool hasPlaced;

    public LayerMask buildingsMask;
    	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 mm = Input.mousePosition;
        mm = new Vector3(mm.x, mm.y, transform.position.y);
        Vector3 p = Camera.main.ScreenToWorldPoint(mm);
		if (selectedBuild != null && !hasPlaced)
       {
           Vector2 m = Input.mousePosition;
            
            selectedBuild.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);

            if (Input.GetMouseButtonDown(0))
            {
                
                if (isLegalPosition())
                {
                  hasPlaced = true;
                }
            }
        }
        else
        {
            // Left Click a building
            if (Input.GetMouseButtonDown(0))
            {
                
                Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
                RaycastHit2D hit = Physics2D.Raycast(rayPos, Vector2.zero, 0f);

                if (hit)
                {
                    // Displays name of building
                    Debug.Log(hit.transform.name);
                    
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
        
    }
}
