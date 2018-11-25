using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinMovement : MonoBehaviour {
    private Animator anim;
    private bool moving;
    public int moveSpeed;

    public int time;
    public float CurrentTime;
 

    private Vector3 moveDirection;
    private Rigidbody2D myRigidbody;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        moving = true;
    }
	
	// Update is called once per frame
	void Update () {
       // while (moving == true)
       // {
           
        myRigidbody.velocity = moveDirection;
        int caseSwitch = caseSwitch = Random.Range(0, 5);

        switch (caseSwitch)
        {
            case 1:
                time = Random.Range(2, 5);
                moveUp();
                
                break;
            case 2:
                time = Random.Range(2, 5);
                moveDown();
                break;
            case 3:
                time = Random.Range(2, 5);
                moveLeft();
                break;
            case 4:
                time = Random.Range(2, 5);
                moveRight();
                break;
            default:

                break;


                // }
        }
        }
    void moveUp()
    {
        while (CurrentTime < time)
        {
            anim.SetFloat("yMove", 1);
            moveDirection = new Vector3(0 * moveSpeed, 1 * moveSpeed, 0f);
            CurrentTime = Time.deltaTime;
        }
      
    }

    void moveDown()
    {
        while (CurrentTime < time)
        {
            anim.SetFloat("yMove", 1);
            moveDirection = new Vector3(0 * moveSpeed, -1 * moveSpeed, 0f);
            CurrentTime = Time.deltaTime;
        }
    }
    

    void moveLeft()
    {
        while (CurrentTime < time)
        {
            anim.SetFloat("yMove", 1);
            moveDirection = new Vector3(-1 * moveSpeed, 0 * moveSpeed, 0f);
            CurrentTime = Time.deltaTime;
        }
    }

    void moveRight()
    {
        while (CurrentTime < time)
        {
            anim.SetFloat("yMove", 1);
            moveDirection = new Vector3(1 * moveSpeed, 1 * moveSpeed, 0f);
            CurrentTime = Time.deltaTime;
        }
    }
}
