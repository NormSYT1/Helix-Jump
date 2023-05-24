using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointControl : MonoBehaviour
{
    private GameSettings control;//Baþka script'deki deðiþkenlere eriþim 
    void Start()
    {
        control = GameObject.FindObjectOfType<GameSettings>();//Baþka script'deki deðiþkenlere eriþim için tanýmlanýr
    }
    void OnTriggerEnter(Collider other)
    {
        control.Game_Score(25);//25 puan ekler
    }
}
