using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class OptionsController : MonoBehaviour {
    
    public Slider volumeSlider,diffSlider;
    public LevelManager levelManager;
    private MusicManager musicManager;
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManeger.GetMasterVolume();
        diffSlider.value = PlayerPrefsManeger.GetDifficulty();
	}
	
	
	void Update () {
        musicManager.SetVolume(volumeSlider.value);
	}

    public void SaveAndExit()
    {
      PlayerPrefsManeger.SetMasterVolume(volumeSlider.value);
        levelManager.LoadLevel("Start Menu");
        PlayerPrefsManeger.SetDifficulty(diffSlider.value);

    }
    public void setDefaults()
    {
        volumeSlider.value = 0.8f;
        diffSlider.value = 2f;
    }
}
