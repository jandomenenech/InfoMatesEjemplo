using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ControladorDeDisparo : MonoBehaviour
{
    public DisparoVertical disparoVerticalScript;
    public Rigidbody2D Rigidbody2;
    public float velocidad;

    void Start()
    {
        Rigidbody2 = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
        Rigidbody2.velocity = Vector3.up * velocidad;
        Destroy(Rigidbody2,3f);
    }
       
}




