using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    public int score = 0;
    public  Text myText;
    public static ScoreKeeper Instance;
    public Text endText;
    

    private void Awake()
    {
        Instance = this;
    }


    void Start()
    {

        score = 0;

    }





    public void Score()
    {
    
        
            score += 50;
            myText.text = "SCORE:" + score;
        endText.text = myText.text;

    }
    
}
