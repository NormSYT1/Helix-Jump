using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public Transform ball;//Konum için gerekli nesne
    private Vector3 offset;//Pozisyon için gerekli
    public float smooth_speed = 0.05f;//Yumuþak geçiþ için gerekli deðiþken
    void Start()
    {
        offset = transform.position - ball.position;//Kameranýn pozisyonundan topun pozisyonunun mesafe farký 
    }    
    void Update()
    {
        Vector3 new_position = Vector3.Lerp(transform.position, offset + ball.position, smooth_speed);//Nesnenin yeni konumu
        transform.position = new_position;//Yeni konumunu anlýk konumuna eþitler
    }
}
