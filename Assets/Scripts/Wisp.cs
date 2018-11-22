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
    private Vector3 lumberTentPosition;

    private Vector3 wispTravelTo;
    private float[] distArray;
    public float Dist;
    public float distanceTolerance;


    private TreeSpawner treeSpawner;
    private lumberTent lumberTent;
    private PlayerStats playerStats;

    private Trees Trees;

    // Use this for initialization
    void Start() {
        counter = 0;
        treeSpawner = FindObjectOfType<TreeSpawner>();
        lumberTent = FindObjectOfType<lumberTent>();
        playerStats = FindObjectOfType<PlayerStats>();
        lumberTentPosition = lumberTent.transform.position;
        Trees = FindObjectOfType<Trees>();
        harvesting = true;


    }

    // Update is called once per frame
    void Update() {

        for (int i = 0; i < treeSpawner.treeArray.Length; i++)
        {
            tree = treeSpawner.treeArray[i];
            treePosition = tree.transform.position;
            Dist = Vector3.Distance(treePosition, transform.position);
           
            

                if (Dist <= distanceTolerance)
                {
                Debug.Log("GotOne");
                    if (harvesting == true)
                    {
                        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), tree.transform.position, moveSpeed * Time.deltaTime);

                    }
                    //  transform.position = tree.transform.position;
                }
                if (harvesting == false)
                {
                    transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), lumberTentPosition, moveSpeed * Time.deltaTime);

                }
            
        }
       
        }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Trees")
        {
            harvesting = false;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "lumberTent")
        {
            harvesting = true;
            playerStats.AddLumber(2);
            traveling = false;
        }
    }
}

       

