using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wisp : MonoBehaviour {

    public float moveSpeed;
    public bool harvesting;
    public bool traveling;
    private int counter;

    private GameObject tree;
    private Vector2 moveDirection;
    private Vector3 treePosition;
    
    private Vector3 wispTravelTo;
    private float[] distArray;
    public float Dist;
    public float distanceTolerance;
    

    private TreeSpawner treeSpawner;
    
    
	// Use this for initialization
	void Start () {
        counter = 0;
        treeSpawner= FindObjectOfType<TreeSpawner>();
    }

    // Update is called once per frame
    void Update() {
        while(traveling == false && harvesting == false && counter<=70)
        {
            tree = treeSpawner.treeArray[counter];
            treePosition = tree.transform.position;
            Dist = Vector3.Distance(treePosition, transform.position);
            Debug.Log(Dist);
            if (Dist <= distanceTolerance)
            {
                transform.position = tree.transform.position;
                counter = 0;

            }
            else { counter++; }
        }


    }

        /*   for (int i = 0; i < treeSpawner.treeArray.Length; i++)
           {
               tree = treeSpawner.treeArray[i];

               treePosition = tree.transform.position;
               Dist = Vector3.Distance(treePosition, transform.position);
               Debug.Log(Dist);
               if (Dist <= distanceTolerance)
               {
                   transform.position = tree.transform.position;
               }
           }
           */



    





    }

 

