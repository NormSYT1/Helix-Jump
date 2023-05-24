using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public Transform ball;//Konum i�in gerekli nesne
    private Vector3 offset;//Pozisyon i�in gerekli
    public float smooth_speed = 0.05f;//Yumu�ak ge�i� i�in gerekli de�i�ken
    void Start()
    {
        offset = transform.position - ball.position;//Kameran�n pozisyonundan topun pozisyonunun mesafe fark� 
    }    
    void Update()
    {
        Vector3 new_position = Vector3.Lerp(transform.position, offset + ball.position, smooth_speed);//Nesnenin yeni konumu
        transform.position = new_position;//Yeni konumunu anl�k konumuna e�itler
    }
}
