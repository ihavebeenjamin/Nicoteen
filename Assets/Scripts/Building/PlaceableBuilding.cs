using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableBuilding : MonoBehaviour {
    // [HideInInspector]
    public List<Collider2D> colliders = new List<Collider2D>();
    public float collideCounter;
    
	// Use this for initialization
	void Start () {
        collideCounter = 0;
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D c) {
        if (c.tag == "Building")
        {
            colliders.Add(c);
            collideCounter++;
            //Debug.Log("Collide");
           
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "Building")
        {
            
            colliders.Remove(c);
            collideCounter--;

        }
    }

}

