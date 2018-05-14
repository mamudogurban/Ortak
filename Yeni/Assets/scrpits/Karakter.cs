using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour {
    public float fall;
    public float jump;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Update()  {

        if (rb.velocity.y < 0) 
            { rb.velocity += Vector3.up * Physics.gravity.y * (fall ) * Time.deltaTime; }

        else if (rb.velocity.y > 0 && Input.GetButtonDown("Jump"))
        {

            rb.velocity += Vector3.up * Physics.gravity.y * (jump ) * Time.deltaTime;


        }


    }


            
        }




    


