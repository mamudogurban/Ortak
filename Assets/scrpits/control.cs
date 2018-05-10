using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public GameObject zemin1;
    public GameObject zemin2;
    float uzunluk = 0;

    public GameObject player;



    void Start()
    {
        uzunluk = zemin1.GetComponent<BoxCollider>().size.x;

    }


    void Update()
    {




        if (player.transform.position.x/3> zemin1.transform.position.x)
        {
            zemin1.transform.position += new Vector3(zemin1.transform.position.x*4 ,0);
        }
        if (player.transform.position.x/3> zemin2.transform.position.x)
        {
            zemin2.transform.position += new Vector3(zemin2.transform.position.x *4, 0);
        }
    }
}