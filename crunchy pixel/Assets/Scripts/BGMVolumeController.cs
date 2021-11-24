using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMVolumeController : MonoBehaviour
{
    public Slider bgm_slider;
    public AudioSource bgmmusic_audioSource;
    void Start()
    {
        bgm_slider.value = PlayerPrefs.GetFloat("bgm_slider_value", 0.20f);
        bgmmusic_audioSource.volume = bgm_slider.value;
    }

    // Update is called once per frame
    public void Update()
    {
        PlayerPrefs.SetFloat("bgmusic_slider_value", bgm_slider.value);
        bgmmusic_audioSource.volume = bgm_slider.value;
    }
}
