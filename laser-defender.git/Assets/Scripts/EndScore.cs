using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {
    public static EndScore Instance3;
    public Text endText;
    private int score;



    void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	public void end () {
        endText.text = "Your Score:" + score;
        score += 50;
	}
}
