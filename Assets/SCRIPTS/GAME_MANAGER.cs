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
        currentSong = 0; //comen�a des de sa primera can��
        
        UpdateTextSong(); 
    }

    public void PlaySong()//si posam m�s d'un par�metre no anir� be
    {
        _audioSource.clip = songs[currentSong]; //asignar es clip especific que volem (�Quina can�� volem reprodu�r?)

        _audioSource.Play();

    }

    public void NextSong()
    {
        _audioSource.Stop(); //aturam can�� que sona

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
        _audioSource.Stop(); //aturam can�� que sona

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
        currentSong = Random.Range(0, songs.Length); //triam numero aleatori de can��
        PlaySong();
        UpdateTextSong();
    }

    private void UpdateTextSong()
    {
        songText.text = $"{songs[currentSong].name}";
    }

    public void RestartSong()
    {
        _audioSource.Stop(); //aturam sa can�� que est� sonant, perqu� reinicia
        PlaySong(); 
    }

    /*
     * -objete red� (torus aplanat --> prefab)
     * -script per ell --> transform
     * -comunicaci� entres sacripts per :
     *      - dins sa funci� play posam instanciar objecte + color des torus = color current song
     *      - dins sa funci� stop destroy
     *      
     */

    private void StartMoving()
    {
        //while
    }

}


