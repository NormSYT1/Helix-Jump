using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;//Rigidbody'ye eriþim
    public float jump = 7f;//Zýplama deðiþkeni
    public GameObject splash, panel;//Oyun nesnesine eriþmek için gerekli deðiþkenleri
    GameSettings control1;//Baþka script'deki deðiþkenlere eriþim için
    public Button button1, button2;//Buton deðiþkenleri
    public AudioClip sound;//Ses deðiþkeni
    void Start()
    {
        control1 = GameObject.FindObjectOfType<GameSettings>();//Baþka script'deki deðiþkenlere eriþmek için tanýmlanýr
        Time.timeScale = 1;//Oyun devam eder
        AudioListener.volume = 1;//Oyunun ana sesi çalar
    }
    void OnCollisionEnter(Collision collision)
    {
        GameObject go = Instantiate(splash, new Vector3(transform.position.x, collision.transform.position.y - 0.12f, transform.position.z), transform.rotation) ;//Çarpma lekesini çarpan konumda oluþturur
        Destroy(go, 2f);//Animasyonu 2 saniye içinde yok eder
        go.transform.SetParent(collision.gameObject.transform);//Çarpma lekesini çarpýlan nesnenin konumuna eþitle
        string material_name = collision.gameObject.GetComponent<MeshRenderer>().material.name;//Materyale eriþim
        if (material_name == "SafeColor (Instance)")//Top güvenli alana çarparsa
        {
            rb.velocity = Vector3.up * jump;//Topa kuvvet uygular
            AudioSource.PlayClipAtPoint(sound, transform.position);//Çarpma Sesi çalar
        }
        else if (material_name == "UnsafeColor (Instance)")//Top güvensiz alana çarparsa
        {
            Cursor.visible = true;//Ýmleci görünür yap
            AudioListener.volume = 0;//Oyunun ana sesi durur
            Time.timeScale = 0;//Oyun durur
            AudioSource.PlayClipAtPoint(sound, transform.position);//Topun çarpma sesi çalar
            button1.gameObject.SetActive(true);//Bölümü tekrar oynamak için gereken buton aktif hale gelir
            button2.gameObject.SetActive(true);//Ana menüye dönmek için gereken buton aktif hale gelir
            panel.gameObject.SetActive(true);//Panel aktif(görünür) hale gelir
            control1.finalScore.gameObject.SetActive(true);//Son skoru ekranda yazar
        }   
    }
}
