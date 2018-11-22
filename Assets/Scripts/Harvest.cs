using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour {
    public int damageToGive;
   
	// Use this for initialization
	void Start () {
     
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Trees")
        {
            other.gameObject.GetComponent<Trees>().LoseHealth(damageToGive);
        }
    }
}
