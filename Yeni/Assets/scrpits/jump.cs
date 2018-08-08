using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{

    bool ziplamaKontrol;
    private bool reachTop;
    
    private float minus = 0.5f;
  
    void Start()
    {
     
        ziplamaKontrol = false;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && ziplamaKontrol)
        {

            minus = 0.5f;

            ziplamaKontrol = false;
            reachTop = false;
        }

        if (!ziplamaKontrol)
        {

            if (transform.position.y > 15)
            {
                reachTop = true;
            }

            if (!reachTop)
            {
                transform.position += Vector3.up * minus;
                minus += 0.005f;
            }
            else
            {
                transform.position -= Vector3.up * minus;
                minus -= 0.003f;
            }

        }




    }

    void OnCollisionEnter(Collision collision)
    {

        ziplamaKontrol = true;
    }

}