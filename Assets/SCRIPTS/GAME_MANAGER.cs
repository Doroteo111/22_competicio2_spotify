using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GAME_MANAGER : MonoBehaviour
{
    public AudioClip[] songs;
    public int currentSong;
    private AudioSource _audioSource;
    public TextMeshProUGUI songText;
    public GameObject disk;
    public bool isPlaying;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        currentSong = 0; //comença des de sa primera cançó
        
        UpdateTextSong(); 
    }

    public void PlaySong()//si posam més d'un paràmetre no anirà be
    {
        _audioSource.clip = songs[currentSong]; //asignar es clip especific que volem (¿Quina cançó volem reproduïr?)

        _audioSource.Play();

    }

    public void NextSong()
    {
        _audioSource.Stop(); //aturam cançó que sona

        //reiniciar s'array
        if (++currentSong >= songs.Length)
            {
            currentSong = 0;
            }

        UpdateTextSong(); //update text

        PlaySong();
    }

    public void AntSong()
    {
        _audioSource.Stop(); //aturam cançó que sona

        //reiniciar s'array

        if (--currentSong < 0)
        {
            currentSong = songs.Length-1;
        }
        UpdateTextSong();

        PlaySong();
    }

    public void RandomSong()
    {
        currentSong = Random.Range(0, songs.Length); //triam numero aleatori de cançó
        PlaySong();
        UpdateTextSong();
    }

    private void UpdateTextSong()
    {
        songText.text = $"{songs[currentSong].name}";
    }

    public void RestartSong()
    {
        _audioSource.Stop(); //aturam sa cançó que està sonant, perquè reinicia
        PlaySong(); 
    }

    /*
     * -objete redó (torus aplanat --> prefab)
     * -script per ell --> transform
     * -comunicació entres sacripts per :
     *      - dins sa funció play posam instanciar objecte + color des torus = color current song
     *      - dins sa funció stop destroy
     *      
     */

    private void StartMoving()
    {
        //while
    }

}


