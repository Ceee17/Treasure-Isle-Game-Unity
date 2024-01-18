using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Slider sliderMusic;
    public AudioSource audioSource;
    public float volume = 1;
    public const string keyVolume = "VOLUME";

    // Singleton instance
    private static SoundManager instance;

    private void Awake()
    {
        // Ensure only one instance of SoundManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
            Initialize();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Initialize()
    {
        // Load volume from PlayerPrefs
        float lastPlayerPrefs = PlayerPrefs.GetFloat(keyVolume);
        onSlide(lastPlayerPrefs);
        sliderMusic.value = lastPlayerPrefs;
    }

    public void onSlide(float nilaiSlider)
    {
        volume = nilaiSlider;
        audioSource.volume = nilaiSlider;

        PlayerPrefs.SetFloat(keyVolume, nilaiSlider);
    }
}
