using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminhareket : MonoBehaviour
{

    public float hiz;


    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector3.left * hiz * Time.deltaTime);



    }















}
