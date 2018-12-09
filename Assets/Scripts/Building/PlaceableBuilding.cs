using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableBuilding : MonoBehaviour {
    // [HideInInspector]
    public List<Collider> colliders = new List<Collider>();
    public float collideCounter;
    
	// Use this for initialization
	void Start () {
        collideCounter = 0;
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider c) {
        if (c.tag == "Building")
        {
            colliders.Add(c);
            collideCounter++;

           
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Building")
        {
            
            colliders.Remove(c);
            collideCounter--;

        }
    }

}

