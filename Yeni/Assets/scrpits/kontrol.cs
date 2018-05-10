using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour {
    public GameObject obj;

    void Start()
    {
        Spawn();
    }


    void Spawn()
    {
        Instantiate(obj, transform.position, Quaternion.identity);




    }
}

