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
        currentSong = 0; //comen�a des de sa primera can��

    }

    public void PlaySong()//si posam m�s d'un par�metre no anir� be
    {
        _audioSource.clip = songs[currentSong]; //asignar es clip especific que volem (�Quina can�� volem reprodu�r?)

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
        perque torni a comen�ar es recorregut de s'array
        "SI LI PASAM DE CAN�� I S'HA ACABT S'ARRAY, REINICIAM S'ARRAY"
    */

    /*FALTA PER POSAR
     *      -cridar PlaySong();
     *      
     */
}


