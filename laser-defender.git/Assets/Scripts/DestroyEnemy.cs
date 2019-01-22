using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyEnemy : MonoBehaviour {

    public GameObject enemylaser;

    private float health = 200f;
    private float shotPerSec = 0.5f;

    public AudioClip fireSound;
    public AudioClip deadSound;
    public static DestroyEnemy Instance1;
    public AudioClip nextPosSound;
    private LevelManager levMan;


    private void Awake()
    {
        Instance1 = this;
    }


    void Start()
    {


      
       
    }




    private void Update()
    {
        float probobality = Time.deltaTime * shotPerSec;
        if (Random.value < probobality)
        {
            Fire();
        }


    }



    void Fire()
    {

        AudioSource.PlayClipAtPoint(fireSound, transform.position);

        Vector3 offset = new Vector3(0, -1, 0);
        Vector3 startPos = transform.position + new Vector3(0, -1, 0);
        GameObject missile = Instantiate(enemylaser, startPos+offset, Quaternion.identity) as GameObject;
        missile.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -5);
    }


    void OnTriggerEnter2D(Collider2D collider)
    {

      HpController missile=  collider.gameObject.GetComponent<HpController>();
        if (missile)
        {
            health -= missile.GetDamage();
            missile.Hit();
        }
       
        if (health <= 0)
        {
            Destroy(gameObject);

            AudioSource.PlayClipAtPoint(deadSound, transform.position);
            ScoreKeeper.Instance.Score();
           
            
            
        }
       
    }
    public void nextPos()
    {
        AudioSource.PlayClipAtPoint(nextPosSound, transform.position);
    }
}
