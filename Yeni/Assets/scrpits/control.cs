using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public GameObject zemin1;
    public GameObject zemin2;
    

    public GameObject player;



    void Start()
    {
   

    }


    void Update()
    {




        if (player.transform.position.x/3> zemin1.transform.position.x)
        {
            zemin1.transform.position = new Vector3(zemin1.transform.position.x+120 ,0);
        }
        if (player.transform.position.x/3> zemin2.transform.position.x)
        {
            zemin2.transform.position = new Vector3(zemin2.transform.position.x+120, 0);
        }
    }
}