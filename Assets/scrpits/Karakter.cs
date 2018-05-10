using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour {
    public float zıplamaGucu;
    Rigidbody2D agirlik;
    Vector3 vec;
    void Start()
    {
        agirlik = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            {
            agirlik.AddForce(Vector3.up * zıplamaGucu);



            
        }


            
        }




    }


