using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    public float jumpPower;
    bool ziplamaKontrol;
	void Start () {

        ziplamaKontrol = false;
	}
	
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)&& ziplamaKontrol)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpPower;

            ziplamaKontrol = false;
        }
          


        
        }


     void OnCollisionEnter(Collision collision)
    {


        ziplamaKontrol = true;
    }
}

