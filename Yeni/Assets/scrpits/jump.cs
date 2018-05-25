using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    
    bool ziplamaKontrol;
    public float jump1;
    public float jump2;
    public float jump3;
    public float fall1;
    public float fall2;
    
   

    void Start () {

        ziplamaKontrol = false;
	}


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && ziplamaKontrol)
        {
            transform.Translate(Vector3.up * jump1 * Time.deltaTime);




            if (transform.position.y == 4)
            {

                transform.Translate(Vector3.up * jump2 * Time.deltaTime);
                ziplamaKontrol = false;

            }




            if (transform.position.y == 6)
            {

                transform.Translate(Vector3.up * jump3 * Time.deltaTime);

                ziplamaKontrol = false;
            }


            if (transform.position.y == 6)
            {

                transform.Translate(Vector3.down * fall1 * Time.deltaTime);

                ziplamaKontrol = false;
            }


            if (transform.position.y == 3)
            {

                transform.Translate(Vector3.down * fall2 * Time.deltaTime);

                ziplamaKontrol = false;
            }







            ziplamaKontrol = false;





























        }



    }


        
    


     void OnCollisionEnter(Collision collision)
    {


        ziplamaKontrol = true;
    }

}

