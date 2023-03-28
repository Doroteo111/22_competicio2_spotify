using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class volumeCONTROLLER : MonoBehaviour
{
    public GameObject cam;
    private AudioSource _audiosource;
    public Slider volumeSlider;

    public Scrollbar scaleScrollbar;

    public TextMeshProUGUI volumeText;
    public GameObject volumePanel;

    public GameObject sphere1;

    private void Start()
    {
        _audiosource = cam.GetComponent<AudioSource>(); //_audiosource seria igual a s'audiosource de sa camara

        MusicVolume(volumeSlider.value);
        volumePanel.SetActive(false);
    }

    public void MusicVolume(float v)
    {
        _audiosource.volume = v; //de s'audiosource de sa camara agafa'm es volumen
        volumeText.text = $"{v}";

    }
    public void SphereScale()
    {
        sphere1.transform.localScale = Vector3.one * scaleScrollbar.value * 10;
    }
}
