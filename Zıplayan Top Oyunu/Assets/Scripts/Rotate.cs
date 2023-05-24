using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float turn = 350f;//Fareyi d�nd�rmek i�in gereken y�n de�i�keni
    private float x_move = 1f;//X y�n�nde d�nd�rmek h�z de�i�keni 
    void Start()
    {
        Cursor.visible = false;//�mleci g�r�nmez yap
    }
    void Update()
    {
        x_move = Input.GetAxis("Mouse X");//X y�n�nde d�nd�rmek i�in 
        if (Input.GetMouseButton(0))//Farenin sol tu�una t�kland��� s�rece 
        {
            transform.Rotate(0f, -x_move * turn * Time.deltaTime, 0f);//D�n�� i�in
        }    
    }
}
