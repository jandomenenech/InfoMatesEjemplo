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
        /*Vector2 costatSuperior = Camera.main.ViewportToWorldPoint(new Vector2(0, 1));
        if (transform.position.y <= costatSuperior.y)
        {

            Destroy(gameObject);

        }*/
        Destroy(gameObject, tiempoDeVida);
        
    }
    public void depAlien(Collision2D collision)
    {
        Marciano = collision.gameObject.GetComponent<Alien>();
        if (Marciano != null)
        { 
            Marciano.DestruirAlien();
        }
        Destroy(gameObject);
    }



}




       





