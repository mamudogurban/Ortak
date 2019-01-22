using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public float nextLevelTimer;
   
    private void Start()
    {

        if (nextLevelTimer == 0)
        {

        }
        else
        {
            Invoke("LoadNextLevel", nextLevelTimer);
        }

    }



    public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene (name);
        

    }

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel() {
		
		SceneManager.LoadScene(Application.loadedLevel+ 1);
	}
	
	
	}

