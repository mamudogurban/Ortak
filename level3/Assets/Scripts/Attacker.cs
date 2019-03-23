using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {
  
    private float currentSpeed;
    private GameObject currentTarget;
    private Animator animator;

	
	void Start () {
       
        animator = GetComponent<Animator>();
	}
	
	
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!currentTarget)
        {
            animator.SetBool("isAttacking", false);
        }
	}



     void OnTriggerEnter2D()
    {
        Debug.Log(name + "trigger enter");
    }

    public void SetSpeed(float speed)
    {
        currentSpeed = speed;
    }
    public void  StrikeCurrentTarget(float damage)
    {

        if (currentTarget)
        {
            Debug.Log(name + "caused damage" + damage);
            Health health = currentTarget.GetComponent<Health>();

            if (health)
            {
                health.DealDamage(damage);
            }
        }
    }
    public void Attack(GameObject obj)
    {
        currentTarget= obj;
    }
}


