using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float turn = 350f;//Fareyi döndürmek için gereken yön deðiþkeni
    private float x_move = 1f;//X yönünde döndürmek hýz deðiþkeni 
    void Start()
    {
        Cursor.visible = false;//Ýmleci görünmez yap
    }
    void Update()
    {
        x_move = Input.GetAxis("Mouse X");//X yönünde döndürmek için 
        if (Input.GetMouseButton(0))//Farenin sol tuþuna týklandýðý sürece 
        {
            transform.Rotate(0f, -x_move * turn * Time.deltaTime, 0f);//Dönüþ için
        }    
    }
}
