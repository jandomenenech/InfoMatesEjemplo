using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ControladorDeDisparo : MonoBehaviour
{

    public NauJugador nau;
    public Rigidbody2D Rigidbody2;
    public float velocidad;
    private float tiempoDeVida = 2.0f;
    private Alien Marciano;
    

    void Start()
    {
        Rigidbody2 = GetComponent<Rigidbody2D>();
        Rigidbody2.velocity = Vector3.up * velocidad;
        Destroy(gameObject, tiempoDeVida);
        
    }
    void Contacto (Collision2D collision)
    {
        if (collision.gameObject.name == "Numero")
        {
            Destroy(collision.gameObject);
            
        }

    }
    private void onTriggerEnter2D(Collider2D objecteTocat)
    {
        if (objecteTocat.tag == "Numero")
        {
            Destroy(gameObject);
        }
    }
}











       





