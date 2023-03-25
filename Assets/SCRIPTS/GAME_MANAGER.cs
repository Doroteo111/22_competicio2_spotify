using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GAME_MANAGER : MonoBehaviour
{ 
    //MARIA T'ESTIMAM, PERDÓ PERÒ NO SABEM FER-HO AMB MENOS FUNCIONS SORRY :) (pov:un dissapte de sa nostra vida fent programació)

    public AudioClip[] songs;
    public int currentSong;
    private AudioSource _audioSource;
    public TextMeshProUGUI songText;
    public bool isPlaying;
    public float speed = 100;
    public disco discoScript;
    public Sprite[] images;
    public Image foto;
    public TextMeshProUGUI[] playlistText;
    public GameObject playlistPANEL;
    public bool hasClicked;
    public TextMeshProUGUI playlistTex;

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
        UpdateImage();

        //asegurar que no surti es panel des de es principi
        playlistPANEL.SetActive(false);
        hasClicked = false;
    }

    private void Update()
    {
        if(isPlaying == true) //mentre soni una canço es disc se mou
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
 
    public void PauseSong() //pausa sa cançó i ja no està playing res
    {
        _audioSource.Pause();
        isPlaying = false;
    }

    private void UpdateImage() //refresca sa imatge
    {
        foto.sprite = images[currentSong];
    }

    private void UpdatePlaylistText() //escrivim tots es nom de ses cançons per ordre segons s'array de cançons
    {
        for(int i=0; i< songs.Length ; i++)
        {
            playlistText[i].text = $"{songs[i].name}";
        }
    }
    
    public void PlaylistButtonPanel()
    {
        if (hasClicked == true) //si ja ha clickat un pic, que veu es panel + canvia es nom des botó 
        {
            playlistPANEL.SetActive(false);
            playlistTex.text = $"playlist";
            hasClicked = false;

        }
        else //si no havia pitjat, (no veu es panel) el mostram i canviam es nom des botó a back
        {
            playlistPANEL.SetActive(true);
            playlistTex.text = $"back";
            hasClicked = true;
        }
    }

    public void StopBTTN()
    {
        _audioSource.Stop(); //aturam musica del tot
        isPlaying = false;
    }

    public void PlaySong0()
    {
        //play audioclip 1
        _audioSource.clip = songs[0]; 
        _audioSource.Play();

        currentSong = 0; //asignam a piñón es valor de sa cançó

        //refrescam imatge i text
        UpdateTextSong(); 
        UpdateImage();
    }
    public void PlaySong1()
    {
        _audioSource.clip = songs[0];
        _audioSource.Play();
        currentSong = 1;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong2()
    {
        _audioSource.clip = songs[2];
        _audioSource.Play();
        currentSong = 2;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong3()
    {
        _audioSource.clip = songs[3];
        _audioSource.Play();
        currentSong = 3;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong4()
    {
        _audioSource.clip = songs[4];
        _audioSource.Play();
        currentSong = 4;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong5()
    {
        _audioSource.clip = songs[5];
        _audioSource.Play();
        currentSong = 5;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong6()
    {
        _audioSource.clip = songs[6];
        _audioSource.Play();
        currentSong = 6;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong7()
    {
        _audioSource.clip = songs[7];
        _audioSource.Play();
        currentSong = 7;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong8()
    {
        _audioSource.clip = songs[8];
        _audioSource.Play();
        currentSong = 8;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong9()
    {
        _audioSource.clip = songs[9];
        _audioSource.Play();
        currentSong = 9;
        UpdateTextSong();
        UpdateImage();
    }
    public void PlaySong10()
    {
        _audioSource.clip = songs[10];
        _audioSource.Play();
        currentSong = 10;
        UpdateTextSong();
        UpdateImage();
    }
}


