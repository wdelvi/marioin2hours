using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject winScreen;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You won the game!!! Wow!");
        winScreen.SetActive(true);
    }
}