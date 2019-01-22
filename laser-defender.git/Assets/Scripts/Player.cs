using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public AudioClip fireSound;

    private float firingRate = 0.2f;
    float xmin;
    float xmax;
    float speed = 15f;
    public GameObject laser;
    



    void Start()
    {
        transform.position = new Vector3(0, -3.74f, 0);
        float distance = transform.position.z - Camera.main.transform.position.z;


        Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));
        Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        xmin = leftmost.x;
        xmax = rightmost.x;

    }

    private void Fire()
    {
        Vector3 offset = new Vector3(0, 1, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject beam = Instantiate(laser, transform.position+offset, Quaternion.identity) as GameObject;
            beam.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5, 0);
            AudioSource.PlayClipAtPoint(fireSound, transform.position);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        float newx = Mathf.Clamp(transform.position.x, xmin, xmax);
        transform.position = new Vector3(newx, this.transform.position.y, this.transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("Fire", 0.00000001f, firingRate);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            CancelInvoke("Fire");
        }

       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Win Screen");
    }
}
