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
        Debug.Log(collideCounter);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider c) {
        if (c.tag == "Building")
        {
            colliders.Add(c);
            collideCounter++;

            Debug.Log(collideCounter);
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Building")
        {
            Debug.Log(collideCounter);
            colliders.Remove(c);
            collideCounter--;

        }
    }

}

