using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {
  
    private float currentSpeed;
    private GameObject currentTarger;

	
	void Start () {
        Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D>();
        myRigidbody.isKinematic = true;
	}
	
	
	void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
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
        Debug.Log(name + "caused damage" + damage);
    }
    public void Attack(GameObject obj)
    {
        currentTarger = obj;
    }
}


