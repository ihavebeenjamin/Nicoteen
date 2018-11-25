using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoblinMovement : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;

    private Rigidbody2D myRigidbody;

    public bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;

    public float timeToMove;
    private float timeToMoveCounter;

    private int switchCase;

    private Vector3 moveDirection;

    public float waitToReload;
    private bool reloading;
    private GameObject thePlayer;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();

        //  timeBetweenMoveCounter = timeBetweenMove;
        //  timeToMoveCounter = timeToMove;

        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * .75f, timeToMove * 1.25f);

    }

    // Update is called once per frame
    void Update()
    {
       
        if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = moveDirection;

            if (timeToMoveCounter < 0f)
            {
                moving = false;
                anim.SetBool("Moving", false);
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
            }
        }
        else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidbody.velocity = Vector2.zero;

            if (timeBetweenMoveCounter < 0f)
            {
                timeToMoveCounter = Random.Range(timeToMove * .75f, timeToMove * 1.25f);
                switchCase = Random.Range(1, 5);
                moving = true;
                anim.SetBool("Moving", true);
                switch (switchCase)
                    
                {
                    case 1:
                        anim.SetFloat("xMove", -1);
                        anim.SetFloat("yMove", 0);
                        anim.SetFloat("xLast", -1);
                        anim.SetFloat("yLast", 0);
                        Debug.Log("Moving Left");
                        moveDirection = new Vector3(-1 * moveSpeed, 0, 0f);
                        
                        break;

                    case 2:
                        anim.SetFloat("yMove", 0);
                        anim.SetFloat("xMove", 1);
                        anim.SetFloat("yLast", 0);
                        anim.SetFloat("xLast", 1);
                        Debug.Log("Moving Right");
                        moveDirection = new Vector3(1 * moveSpeed, 0, 0f);
                       
                        break;

                    case 3:
                        anim.SetFloat("xMove", 0);
                        anim.SetFloat("yMove", 1);
                        anim.SetFloat("xLast", 0);
                        anim.SetFloat("yLast", 1);
                        Debug.Log("Moving up");
                        moveDirection = new Vector3(0, 1*moveSpeed, 0f);
                       
                        break;
                    case 4:
                        anim.SetFloat("xMove", 0);
                        anim.SetFloat("yMove", -1);
                        anim.SetFloat("xLast", 0);
                        anim.SetFloat("yLast", -1);
                        moveDirection = new Vector3(0, -1*moveSpeed, 0f);
                        Debug.Log("Moving Down");

                        Debug.Log("Movingup");
                        break;
                    default:
                        anim.SetBool("Moving", false);
                        break;


                }
               

               // moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, 0 * moveSpeed, 0f);
            }

        }
        if (reloading)
        {
            waitToReload -= Time.deltaTime;
            if (waitToReload <= 0)
            {
                SceneManager.LoadScene("main");
                thePlayer.SetActive(true);

            }
        }
    }

}
