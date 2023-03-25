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
    public float speed = 100;

    public disco discoScript;

    public Sprite[] images;
    public Image foto;

    public TextMeshProUGUI[] playlistText;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        discoScript = FindObjectOfType<disco>();
    }

    private void Start()
    {
        currentSong = 0; //comença des de sa primera cançó
        isPlaying = false;
        UpdateTextSong();
        UpdatePlaylistText();
    }

    private void Update()
    {
        if(isPlaying == true)
        {
            discoScript.DiskMovement();
        }
    }

    public void PlaySong()//si posam més d'un paràmetre no anirà be
    {
        _audioSource.clip = songs[currentSong]; //asignar es clip especific que volem (¿Quina cançó volem reproduïr?)
        _audioSource.Play();

        isPlaying = true;

        UpdateImage();
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
 
    public void PauseSong()
    {
        _audioSource.Pause();
        isPlaying = false;
    }

    private void UpdateImage()
    {
        foto.sprite = images[currentSong];
    }

    private void UpdatePlaylistText()
    {
        for(int i=0; i< songs.Length ; i++)
        {
            playlistText[i].text = $"{songs[i].name}";
        }
    }
    

}


