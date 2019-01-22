using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();

        if (musicManager)
        {
            float volume = PlayerPrefsManeger.GetMasterVolume();
            musicManager.SetVolume(volume);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
