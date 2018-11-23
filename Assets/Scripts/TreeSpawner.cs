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
    public GameObject lastTreeSpawned;

    private float startTime = 5;
    public float currentTime;

    public GameObject[] treeArray;

  

    // Use this for initialization test
    void Start () {
        
        Spawner();
        currentTime = startTime;
	}
	
	// Update is called once per frame
	void Update () {
        
            for (int i = 0; i <= maxTrees; i++)
            {
                RandX = Random.Range(-xRange, xRange);
                RandY = Random.Range(-yRange, yRange);
                location = new Vector2(RandX, RandY);
                if (treeArray[i] == null)
                {
                        treeArray[i] = Instantiate(objectToSpawn, location, transform.rotation);
                        currentTrees++;
             
                }
            

                
            


        }

    }

    public void Spawner()
    {
            for (currentTrees = 0; currentTrees < maxTrees; currentTrees++)
            {
                RandX = Random.Range(-xRange, xRange);
                RandY = Random.Range(-yRange, yRange);
                location = new Vector2(RandX, RandY);
               lastTreeSpawned = Instantiate(objectToSpawn, location, transform.rotation);
                treeArray[currentTrees] = lastTreeSpawned;
                
            
        }
            
    }
    IEnumerator SpawnTree()
    {
        yield return new WaitForSeconds(5f);
        }
}
