using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointControl : MonoBehaviour
{
    private GameSettings control;//Ba�ka script'deki de�i�kenlere eri�im 
    void Start()
    {
        control = GameObject.FindObjectOfType<GameSettings>();//Ba�ka script'deki de�i�kenlere eri�im i�in tan�mlan�r
    }
    void OnTriggerEnter(Collider other)
    {
        control.Game_Score(25);//25 puan ekler
    }
}
