using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMovement : MonoBehaviour {


    Rigidbody rg;
//    GameManager gameManager;

    //starting values



    //movment
    [Range(5, 20)]
    public float intensity;
    [Range(70, 120)]
    public float intensityJump;

    bool grounded;
    Ray contactRay;
    float contactRayValue;
    float moveHorizontal;
    float moveVertical;
    Vector3 movementTutorial;



    
    //--------------diversi movimenti-----------------------

    void CheckGrounded()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, contactRayValue);
        
    }

    // move the ball applying a physical force
    void MoveForce() { 

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rg.AddForce(intensity*Vector3.forward);
            //rg.AddForce(new Vector3(0, 0, intensity));
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rg.AddForce(intensity*Vector3.left);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rg.AddForce(intensity*Vector3.back);

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rg.AddForce(intensity*Vector3.right);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (grounded)
            {
                rg.AddForce(intensityJump * Vector3.up);
            }
            

        }

    }

    // move the ball changing the value of its velocity
    void MoveVelocity()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rg.velocity=intensity * Vector3.forward;
            //rg.AddForce(new Vector3(0, 0, intensity));
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rg.velocity = intensity * Vector3.left;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rg.velocity = intensity * Vector3.back;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rg.velocity = intensity * Vector3.right;
        }

        //if (!Input.anyKey)
        //{
        //    Debug.Log("manas");
        //    rg.velocity = Vector3.zero;
        //}

    }

    //move the ball changing the positioon of the transform
    void MoveTransform()
    {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += intensity * Vector3.forward * Time.deltaTime;
            //rg.AddForce(new Vector3(0, 0, intensity));
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += intensity * Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += intensity * Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += intensity * Vector3.right * Time.deltaTime;
        }

        //if (!Input.anyKey)
        //{
        //    Debug.Log("manas");
        //    rg.velocity = Vector3.zero;
        //}

    }

    //move the ball as in the tutorial
    void MoveTutorial()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        movementTutorial = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rg.AddForce(movementTutorial*intensity);



    }


    //-------------------------------------------------------


    public void StopBall()
    {

        rg.velocity = Vector3.zero;
        rg.angularVelocity = Vector3.zero;

    }


    // Use this for initialization
    void Start () {
        //initialization player
        rg = GetComponent<Rigidbody>();
        contactRayValue = GetComponent<SphereCollider>().radius + 0.01f;

        
    }



    // Update is called once per frame
    void Update ()
    {

        CheckGrounded();
        MoveForce();
        
    }







}
