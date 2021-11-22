using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement2 : MonoBehaviour
{


    public float movespeed = 10f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    bool canLift = true;



    void Start()
    {
        canLift = true;
        var Dis = GetComponent<grab_controller>().enabled = true;



    }

    void FixedUpdate()
    {
        movement.y = Input.GetAxis("Vertical");
        movement.x = Input.GetAxis("Horizontal");
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("speed", movement.sqrMagnitude);


    }


    void Update()
    {


        rb.MovePosition(rb.position + movement * movespeed * Time.deltaTime);



    }

    public void unlockStrength()
    {

        canLift = true;
        var Dis = GetComponent<grab_controller>().enabled = true;

    }

    public void unlockSpeed()
    {

        movespeed = 30;


    }


    public void sameSpeed()
    {
        movespeed = 10;

    }


}
