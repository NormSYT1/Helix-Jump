using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingControl : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        transform.position -= new Vector3(0, 60, 0);//Objeye temas edilince 60 cm aþaðý ötelenir
    }
}
