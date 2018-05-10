using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontrol : MonoBehaviour
{
    public GameObject zemin1;
    public GameObject zemin2;
    float uzunluk = 0;
    public float hiz;


    void Start()
    {
        uzunluk = zemin1.GetComponent<BoxCollider>().size.x;

       
    }


    void Update()
    {

        


        if (zemin1.transform.position.x <= -uzunluk)
        {
            zemin1.transform.position += new Vector3(uzunluk * 2, 0);
        }
        if (zemin2.transform.position.x <= -uzunluk)
        {
            zemin2.transform.position += new Vector3(uzunluk * 2, 0);




        }
    }
}