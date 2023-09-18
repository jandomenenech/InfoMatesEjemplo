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
    public void muerte(Collision2D collision) { 

        if (collision.gameObject.layer == LayerMask.NameToLayer("Alien"))
        {
            
            Marciano = collision.gameObject.GetComponent<Alien>();

            
            if (Marciano != null)
            {
                
                Marciano.DestruirAlien();
            }

            Destroy(gameObject);
        }
    }



}




       





