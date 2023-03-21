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
        perque torni a comen�ar es recorregut de s'array
        "SI LI PASAM DE CAN�� I S'HA ACABT S'ARRAY, REINICIAM S'ARRAY"
    */

    /*FALTA PER POSAR
     *      -cridar PlaySong();
     *      
     */

    public void RandomSong()
    {
        currentSong = Random.Range(0, songs.Length); //triam numero aleatori de can��
        _audioSource.clip = songs[currentSong]; //asign 
        UpdateTextSong();
    }

    private void UpdateTextSong()
    {
        songText.text = $"{songs[currentSong].name}";

    }
}


