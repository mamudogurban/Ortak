using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman : MonoBehaviour
{
    private Transform hedef;

    public float time;
    public float counttime;
    public GameObject enemey;
    


    void Start()
    {
        hedef = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        transform.LookAt(hedef);
        transform.position += transform.forward * 2 * Time.deltaTime;

        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = 0;
        }
        if (time == 0)
        {
            time = counttime;
            Instantiate(enemey, hedef.transform.position, hedef.transform.rotation);
        }




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
