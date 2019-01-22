using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {
    public AudioClip[] levelMusicChange;
    private AudioSource audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    void Start () {

        audioSource = GetComponent<AudioSource>();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChange[level];
        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
