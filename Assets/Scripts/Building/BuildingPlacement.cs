using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacement : MonoBehaviour {

    private Transform currentBuilding;
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
            Debug.Log(m);
            selectedBuild.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);

            if (Input.GetMouseButtonDown(0))
            {
                if (isLegalPosition())
                {
                    hasPlaced = true;
                }
            }
        }
	}

    bool isLegalPosition()
    {
        return true;
    }
    public void SetItem(GameObject b)
    {
        hasPlaced = false;
        selectedBuild = Instantiate(b, Input.mousePosition, transform.rotation);
        
        Debug.Log(selectedBuild);
    }
}
