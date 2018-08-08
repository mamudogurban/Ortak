using UnityEngine;

public class Jump : MonoBehaviour{

    private bool _ziplamaKontrol;
    private bool _reachTop;
    
    private float _minus = 0.5f;
  
    void Start(){
        _ziplamaKontrol = false;
    }
    
    void Update(){

        if (transform.position.y <= 2) {
            transform.position = new Vector3(0,2,0);
            _ziplamaKontrol = true;
        }


        if (Input.GetKeyDown(KeyCode.Space) && _ziplamaKontrol){

            _minus = 0.5f;

            _ziplamaKontrol = false;
            _reachTop = false;

        }

        if (!_ziplamaKontrol){

            if (transform.position.y > 15){
                _reachTop = true;
            }

            if (!_reachTop){
                transform.position += Vector3.up * _minus;
                _minus += 0.005f;
            }
            else{
                transform.position -= Vector3.up * _minus;
                _minus -= 0.003f;
            }

        }
        
    }
    /*
    void OnCollisionEnter(Collision collision)
    {

        _ziplamaKontrol = true;
    }
    */
}