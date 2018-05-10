using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrol : MonoBehaviour {
    public GameObject zemin;
    float uzunluk = 0;



    void Start () {


        uzunluk = zemin.GetComponent<BoxCollider>().size.x;
	}
	
	void Update () {

        if(zemin.transform.position.x<=-uzunluk)
        {

            zemin.transform.position += new Vector3(uzunluk * 2, 0);
        }


		
	}
}
