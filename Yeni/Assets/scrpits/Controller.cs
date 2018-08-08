using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Controller : MonoBehaviour{

    public static Controller Instance;

    private Jump _player;
    private GameObject _zemin1;
    private GameObject _zemin2;
    private float maxheigt = 9f;
    private float minheight = 2f;
  

    public List<Enemy> _enemies;
    private Vector3 SizeScale;
    private float delayTimer = 1;
    public Text Puantxt;
    public int Puan;
    private float _timer;
    private bool playing;
    private float hiz = 30f;

    void Awake() {
        Instance = this;
    }

    void Start(){

        _enemies = new List<Enemy>();

        _timer = delayTimer;
        
        Puan = 0;
        playing = true;

        _zemin1 = Instantiate(Resources.Load<GameObject>("Zemin"));
        _zemin1.transform.position = new Vector3(0, 0);

        _zemin2 = Instantiate(Resources.Load<GameObject>("Zemin"));
        _zemin2.transform.position = new Vector3(100, 0);

        _player = Instantiate(Resources.Load<Jump>("Character"));
        _player.transform.position = new Vector3(0,2,0);

    }


    void Update(){
        
        if (!playing){
            return;
        }

        _zemin1.transform.position += Vector3.left*hiz*Time.deltaTime;
        _zemin2.transform.position += Vector3.left*hiz*Time.deltaTime;

        if (_zemin1.transform.position.x < -100) {
            _zemin1.transform.position = new Vector3(_zemin2.transform.position.x + 100, 0);
        }

        if (_zemin2.transform.position.x < -100) {
            _zemin2.transform.position = new Vector3(_zemin1.transform.position.x + 100, 0);
        }
        
        _timer -= Time.deltaTime;

        if (_timer <= 0){

            Enemy enemy = Instantiate(Resources.Load<Enemy>("Enemy"));

            Vector3 sizeScale = new Vector3(1, Random.Range(maxheigt,minheight), 8);

            enemy.transform.localScale = sizeScale;

            enemy.transform.position = new Vector3(30, enemy.transform.localScale.y / 2 + 0.5f, 0);
            
            _timer = Random.Range(0.5f, 2);
            _enemies.Add(enemy);
            
        }

        int len = _enemies.Count;

        List<Enemy> destroyList = new List<Enemy>();

        for (int i = 0; i < len; i++) {
            
            Enemy enemy = _enemies[i];

            if (enemy.transform.position.x <= -15){

                destroyList.Add(enemy);

                continue;
            }

            enemy.transform.position += Vector3.left * hiz*Time.deltaTime;

            if (enemy.PointGiven) {
                continue;
            }

            if (enemy.transform.position.x - enemy.transform.localScale.x / 2 < _player.transform.position.x + _player.transform.localScale.x / 2 && enemy.transform.position.x + enemy.transform.localScale.x / 2 > _player.transform.position.x - _player.transform.localScale.x / 2){

                if (_player.transform.position.y + _player.transform.localScale.y / 2 < enemy.transform.position.y + enemy.transform.localScale.y / 2){
                    for (i = 0; i < _enemies.Count; i++){
                        Destroy(_enemies[i].gameObject);

                        playing = false;
                        Destroy(_player.gameObject);
                    }
                }
                else if (enemy.transform.position.x - enemy.transform.localScale.x / 2 < _player.transform.position.x + _player.transform.localScale.x / 2){

                    _enemies[i].PointGiven = true;
                    Puan += 5;
                }

            }

        }

        len = destroyList.Count;

        for (int i = 0; i < len; i++) {
            DestroyEnemy(_enemies[0]);
        }

        
        Puantxt.text = "PUAN: " + Puan.ToString();

    }

    public void DestroyEnemy(Enemy go){
        GameObject.Destroy(go.gameObject);
        _enemies.Remove(go);
    }

}



















































