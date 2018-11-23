using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wisp : MonoBehaviour
{
    // test change
    public float moveSpeed;
    public bool harvesting;
    public bool traveling;
    public bool carrying;
    private int counter;

    private GameObject tree;
    private Vector2 moveDirection;
    private Vector3 treePosition;
    private Vector3 lumberTentPosition;

    private Vector3 wispTravelTo;
    private float[] distArray;
    public float Dist;
    public float distanceTolerance;


    private TreeSpawner treeSpawner;
    private lumberTent lumberTent;
    private PlayerStats playerStats;
    

    private Trees treeScript;
       // Use this for initialization
    void Start()
    {
        counter = 0;
        treeSpawner = FindObjectOfType<TreeSpawner>();
        lumberTent = FindObjectOfType<lumberTent>();
        playerStats = FindObjectOfType<PlayerStats>();
        lumberTentPosition = lumberTent.transform.position;
        treeScript = FindObjectOfType<Trees>();
        harvesting = false;


    }

    // Update is called once per frame
    void Update()
    {

        if (harvesting == false && carrying == false)
        {
            // Debug.Log;
            for (int i = 0; i < treeSpawner.treeArray.Length; i++)
            {
                tree = treeSpawner.treeArray[i];

               // Debug.Log(i);
                treePosition = tree.transform.position;
                Dist = Vector3.Distance(treePosition, transform.position);



                if (Dist <= distanceTolerance && treeSpawner.treeArray[i].tag != "SelectedTree")
                {
                   // Debug.Log("GotOne");

                    harvesting = true;
                    transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), tree.transform.position, moveSpeed * Time.deltaTime);
                   
                    wispTravelTo = treePosition;
                    treeSpawner.treeArray[i].transform.gameObject.tag = "SelectedTree";
                    i = 100;
                    //  transform.position = tree.transform.position;
                }
                if (harvesting == false)
                {
                    transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), lumberTentPosition, moveSpeed * Time.deltaTime);

                }

                counter = i;

            }
        }
        if (harvesting == true && carrying == false)
        {

            // transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), tree.transform.position, moveSpeed * Time.deltaTime);
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), wispTravelTo, moveSpeed * Time.deltaTime);
            // Debug.Log("Moving to Tree");
            //At this point tree.transform.position is null?

            if (Vector3.Distance(wispTravelTo, transform.position) <= 2)
            {
                harvesting = false;
                carrying = true;
                Destroy(tree);
                
            }

        }
        if (carrying == true)
        {
           transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), lumberTentPosition, moveSpeed * Time.deltaTime);
            //Debug.Log("Going to Tent");
            if (Vector3.Distance(lumberTentPosition, transform.position) <= 1)
            {
                harvesting = false;
                playerStats.AddLumber(2);
                carrying = false;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.gameObject.tag == "Trees")
       // {
        //    harvesting = false;
            // tree.transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
        //    Destroy(other.gameObject);

        //    carrying = true;
           // Debug.Log("Carrying");
       // }

        //if (other.gameObject.tag == "lumberTent")
       // {
         //   harvesting = false;
         //   playerStats.AddLumber(2);
          //  carrying = false;

       // }
    }
}




