using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GAME_MANAGER : MonoBehaviour
{
    public AudioClip[] songs;
    public int currentSong;
    private AudioSource _audioSource;
    public TextMeshProUGUI songText;


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
        if (++currentSong >= songs.Length)
            {
            currentSong = 0;
            }
        UpdateTextSong();

    }

    public void AntSong()
    {
        if (--currentSong < 0)
        {
            currentSong = songs.Length-1;
        }
        UpdateTextSong();

    }

    /*
        perque torni a començar es recorregut de s'array
        "SI LI PASAM DE CANÇÓ I S'HA ACABT S'ARRAY, REINICIAM S'ARRAY"
    */

    /*FALTA PER POSAR
     *      -cridar PlaySong();
     *      
     */

    public void RandomSong()
    {
        currentSong = Random.Range(0, songs.Length); //triam numero aleatori de cançó
        _audioSource.clip = songs[currentSong]; //asign 
        UpdateTextSong();
    }

    private void UpdateTextSong()
    {
        songText.text = $"{songs[currentSong].name}";

    }
}


