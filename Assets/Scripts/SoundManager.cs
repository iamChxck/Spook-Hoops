using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource gameMusic;

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            // if there is no musicVolume key in PlayerPrefs, then create one and set the volume to 1 then load it
            PlayerPrefs.SetFloat("musicVolume", 1);
            LoadVolumeSettings();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Adjusts the volume based on the volume slider
        gameMusic.volume = volumeSlider.value;
    }

    public void MusicSwitch() // Turns the music on or off
    {
        if(gameMusic.isPlaying)
        {
            gameMusic.Stop();
        }
        else
        {
            gameMusic.Play();
        }
    }

    private void LoadVolumeSettings() // Loads the volume settings
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void SaveVolumeSettings() // Saves the volume settings
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
