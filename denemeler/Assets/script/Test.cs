using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
  
  

    
    void Start()
    {
        
    }

    
    void Update()
    {
       
        }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("11111");


        }
    }

}
   

