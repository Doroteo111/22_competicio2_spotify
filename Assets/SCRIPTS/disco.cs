using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco : MonoBehaviour
{
    public GameObject disc;
    public float speed = 100;
    public GAME_MANAGER _gameManager;


    private void Start()
    {
        //_gameManager = FindObjectOfType
    }

    private void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
    


}
