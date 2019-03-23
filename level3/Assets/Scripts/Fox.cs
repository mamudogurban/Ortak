using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof (Attacker))]
public class Fox : MonoBehaviour {

    private Attacker attacker;
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

 void OnTriggerEnter2D(Collider2D collider)
     
    {
        GameObject obj = collider.gameObject;

        if (!obj.GetComponent<Defender>())
        {
            return;
        }
        if (obj.GetComponent<Stone>())
        {
            anim.SetTrigger("jump trigger");
        }
        else
        {
            attacker.Attack(obj);
            anim.SetBool("isAttacking", true);
        }

    }
}
