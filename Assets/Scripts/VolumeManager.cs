using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    public AudioSource music;
    public Slider slider;
    public void Start()
    {
        music.volume =slider.value;
        slider.onValueChanged.AddListener(delegate { OnVolumeChanged(); });

         void OnVolumeChanged()
        {
            music.volume=slider.value;
        }
    }
}
