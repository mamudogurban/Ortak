using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puan : MonoBehaviour {


    

    public Text Puantxt;
    public int Puan;
    
	void Start () {
		
	}


    private void OnTriggerEnter(Collider temas)
    {
        if (temas.gameObject.tag == "sensor")
        {

            Puan+=5;
            Puantxt.text = Puan.ToString();

        }


    }
}
