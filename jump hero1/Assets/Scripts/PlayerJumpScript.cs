﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpScript : MonoBehaviour
{
    public static PlayerJumpScript instance;

    private Rigidbody2D myBody;
    private Animator anim;

    [SerializeField]
    private float forceX, forceY;

    private float tresholdX = 7f;
    private float tresholdY = 14f;

    private bool setPower, didJump;


    void Awake()
    {
        instance = this;
        Initiliaze();
    }

    
    void Update()
    {
        Power();
    }
    
    void Initiliaze()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }



    public void SetPower(bool setPower) {

        this.setPower = setPower;

        if (!setPower)
        {
            Jump();
            
        }
    }
    
    void Power()
    {


        if (setPower)
        {
            forceX += tresholdX * Time.deltaTime;
            forceY += tresholdY * Time.deltaTime;
            if (forceX > 6.5f)
                forceX = 6.5f;

            if (forceY > 13.5f)
            {
                forceY = 13.5f;
            }



        }
    }



    void Jump()
    {
        myBody.velocity = new Vector2(forceX, forceY);
        forceX = forceY = 0f;
        didJump = true;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
     
        if (didJump)
        {
            didJump = false;

            if (target.tag == "platform")
            {
                Debug.Log("tt1");
            }
        }
    }
 }


