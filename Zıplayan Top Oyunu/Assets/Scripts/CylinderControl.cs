using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderControl : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        transform.position += new Vector3(0, transform.GetChild(0).GetComponent<Renderer>().bounds.size.y * -12, 0);//Nesneyi y yönünde aþaðýya doðru öteler
    }
}
