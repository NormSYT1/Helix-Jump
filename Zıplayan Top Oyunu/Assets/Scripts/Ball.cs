using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;//Rigidbody'ye eri�im
    public float jump = 7f;//Z�plama de�i�keni
    public GameObject splash, panel;//Oyun nesnesine eri�mek i�in gerekli de�i�kenleri
    GameSettings control1;//Ba�ka script'deki de�i�kenlere eri�im i�in
    public Button button1, button2;//Buton de�i�kenleri
    public AudioClip sound;//Ses de�i�keni
    void Start()
    {
        control1 = GameObject.FindObjectOfType<GameSettings>();//Ba�ka script'deki de�i�kenlere eri�mek i�in tan�mlan�r
        Time.timeScale = 1;//Oyun devam eder
        AudioListener.volume = 1;//Oyunun ana sesi �alar
    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject go = Instantiate(splash, new Vector3(transform.position.x, collision.transform.position.y - 0.12f, transform.position.z), transform.rotation) ;//�arpma lekesini �arpan konumda olu�turur
        Destroy(go, 2f);//Animasyonu 2 saniye i�inde yok eder
        go.transform.SetParent(collision.gameObject.transform);//�arpma lekesini �arp�lan nesnenin konumuna e�itle
        string material_name = collision.gameObject.GetComponent<MeshRenderer>().material.name;//Materyale eri�im
        if (material_name == "SafeColor (Instance)")//Top g�venli alana �arparsa
        {
            rb.velocity = Vector3.up * jump;//Topa kuvvet uygular
            AudioSource.PlayClipAtPoint(sound, transform.position);//�arpma Sesi �alar
        }
        else if (material_name == "UnsafeColor (Instance)")//Top g�vensiz alana �arparsa
        {
            Cursor.visible = true;//�mleci g�r�n�r yap
            AudioListener.volume = 0;//Oyunun ana sesi durur
            Time.timeScale = 0;//Oyun durur
            AudioSource.PlayClipAtPoint(sound, transform.position);//Topun �arpma sesi �alar
            button1.gameObject.SetActive(true);//B�l�m� tekrar oynamak i�in gereken buton aktif hale gelir
            button2.gameObject.SetActive(true);//Ana men�ye d�nmek i�in gereken buton aktif hale gelir
            panel.gameObject.SetActive(true);//Panel aktif(g�r�n�r) hale gelir
            control1.finalScore.gameObject.SetActive(true);//Son skoru ekranda yazar
        }   
    }
}
