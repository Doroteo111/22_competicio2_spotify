using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME_MANAGER : MonoBehaviour
{
    public AudioClip[] songs;
    public int currentSong;
    private AudioSource _audioSource;


    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    private void Start()
    {
        currentSong = 0; //comença des de sa primera cançó

    }

    public void PlaySong()//si posam més d'un paràmetre no anirà be
    {
        _audioSource.clip = songs[currentSong]; //asignar es clip especific que volem (¿Quina cançó volem reproduïr?)

        _audioSource.Play();

    }

    public void NextSong()
    {
        if (currentSong++ >= songs.Length)
            {
            currentSong = 0;
            _audioSource.clip = songs[currentSong];
            }
       PlaySong();
    }

    public void AntSong()
    {
        if (currentSong-- < 0)
        {
            currentSong = songs.Length-1;
            _audioSource.clip = songs[currentSong];
        }
        PlaySong();
    }

    /*
        perque torni a començar es recorregut de s'array
        "SI LI PASAM DE CANÇÓ I S'HA ACABT S'ARRAY, REINICIAM S'ARRAY"
    */

    /*FALTA PER POSAR
     *      -cridar PlaySong();
     *      
     */
}


