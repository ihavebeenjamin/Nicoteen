using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour {


    private float RandX;
    private float RandY;

    public bool spawning;

    public int maxTrees;
    public int currentTrees;
    public int xRange;
    public int yRange;

    private Vector2 location;
    public GameObject objectToSpawn;

    // Use this for initialization
    void Start () {
        
        Spawner();
	}
	
	// Update is called once per frame
	void Update () {
        if(currentTrees <= maxTrees)
        {
            RandX = Random.Range(-xRange, xRange);
            RandY = Random.Range(-yRange, yRange);
            location = new Vector2(RandX, RandY);
            Instantiate(objectToSpawn, location, transform.rotation);
            currentTrees++;
        }

    }

    public void Spawner()
    {
            for (currentTrees = 0; currentTrees <= maxTrees; currentTrees++)
            {
                RandX = Random.Range(-xRange, xRange);
                RandY = Random.Range(-yRange, yRange);
                location = new Vector2(RandX, RandY);
                Instantiate(objectToSpawn, location, transform.rotation);
                
            
        }
            
    }
    IEnumerator SpawnTree()
    {
        yield return new WaitForSeconds(20);
        }
}
