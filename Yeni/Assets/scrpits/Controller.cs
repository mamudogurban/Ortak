using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class Controller : MonoBehaviour
{
    public static Controller instance;
    public GameObject Player;
    public GameObject Zemin1;
    public GameObject Zemin2;
    private float maxheigt = 9f;
    private float minheight = 1f;
  

    public List<Enemy> _enemies;
    private Vector3 SizeScale;
    private float delayTimer = 2;
    public Text Puantxt;
    public int Puan;
    private float timer;
    private bool _pointGiven;
    private bool playing;
    private float hiz = 30f;

    

    void Start()
    {

        timer = delayTimer;

        _enemies = new List<Enemy>();
        instance = this;
        Puan = 0;
        playing = true;

    }


    void Update(){


        if (!playing){
            return;
        }

        timer -= Time.deltaTime;
        if (timer <= 0){

          Enemy enemy = Instantiate(Resources.Load<Enemy>("Enemy"));

           Vector3 SizeScale= new Vector3(1,Random.Range(maxheigt,minheight),8);

            

            if (_enemies.Count < 1)
            {
                enemy.transform.position = new Vector3(20, enemy.transform.localScale.y / 2 - 1, 0);


            }else{
                enemy.transform.position = new Vector3(Random.Range(_enemies[_enemies.Count - 1].transform.position.x, 20), enemy.transform.localScale.y / 2 - 1, 0);



            }



            timer = delayTimer;
            _enemies.Add(enemy);





        }

        /*if (enemy.position.x <= -15)
        {
            Destroy(gameObject);
            instance.destroyEnemy(gameObject.GetComponent<Enemy>());
        }*/







        

        Puantxt.text = "PUAN:" + Puan.ToString();



        for (int i = 0; i < _enemies.Count; i++)
        {


            Enemy enemy = _enemies[i];

            enemy.transform.position += Vector3.left * hiz*Time.deltaTime;
            
            if (enemy.pointGiven)
                continue;
            {


                if (enemy.transform.position.x - enemy.transform.localScale.x / 2 <
                    Player.transform.position.x + Player.transform.localScale.x / 2 &&
                    enemy.transform.position.x + enemy.transform.localScale.x / 2 >
                    Player.transform.position.x - Player.transform.localScale.x / 2)
                {

                    if (Player.transform.position.y + Player.transform.localScale.y / 2 <
                        enemy.transform.position.y + enemy.transform.localScale.y / 2)
                    {
                        for (i = 0; i < _enemies.Count; i++)
                        {
                            Destroy(_enemies[i].gameObject);

                            playing = false;
                            Destroy(Player.gameObject);
                        }



                    }
                    else if (enemy.transform.position.x - enemy.transform.localScale.x / 2 <
                             Player.transform.position.x + Player.transform.localScale.x / 2)

                    {

                        _enemies[i].pointGiven = true;


                        Puan += 5;





                    }

                    if (transform.position.x <= -15)
                    {
                        Destroy(gameObject);
                        destroyEnemy(gameObject.GetComponent<Enemy>());
                    }


                }






            }



        }

       
        

        Zemin1.transform.Translate(Vector3.left * hiz * Time.deltaTime);
        Zemin2.transform.Translate(Vector3.left * hiz * Time.deltaTime);
        
        if (Zemin1.transform.position.x <= -50)
        {
            Zemin1.transform.position = new Vector3(Zemin1.transform.position.x + 120, -1.6f);

        }

        if (Zemin2.transform.position.x < -50)
        {
            Zemin2.transform.position = new Vector3(Zemin2.transform.position.x + 120, -1.6f);
        }
    }

    


    public void destroyEnemy(Enemy go)
    {
        _enemies.Remove(go);
    }

}



















































