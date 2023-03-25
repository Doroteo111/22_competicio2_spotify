using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disco : MonoBehaviour
{
    public float speed = 1;
    //public GAME_MANAGER gameManagerScript;

    private void Start()
    {
        //gameManagerScript = FindObjectOfType<>()
    }

    public void DiskMovement()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime * 5);
    }
}
