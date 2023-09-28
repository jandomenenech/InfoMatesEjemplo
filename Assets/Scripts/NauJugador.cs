using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    
    public float velocidad;
    public float velocidadY;
    private Camera mainCamera;
    private float minX, maxX, minY, maxY;
    public GameObject bala;
    private float TiempoDisparo;
    private Rigidbody2D rb;
    private float desplazamientoX;
    private float desplazamientoY;
    public GameObject PreabExplosio;

    private float movimientoHorizontal;
    private float movimientoVertical;

    void Start()
    {
        mainCamera = Camera.main;
        CalcularLimitesDeCamara();
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");

        MovieminetoNave();
        Disparo();
    }

    public void CalcularLimitesDeCamara()
    {
        Vector3 esquinaInferiorIzquierda = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 esquinaSuperiorDerecha = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0)); 

        minX = esquinaInferiorIzquierda.x;
        maxX = esquinaSuperiorDerecha.x;
        minY = esquinaInferiorIzquierda.y;
        maxY = esquinaSuperiorDerecha.y;
    }
    public void posicionDisparo(float numX ,float numY)
    {
        GameObject bullet = Instantiate(bala, transform.position + new Vector3(movimientoHorizontal* desplazamientoX + numX, movimientoVertical * desplazamientoY + numY, 0), Quaternion.identity);
    }
    public void MovieminetoNave()
    {
        desplazamientoX = velocidad * Time.deltaTime;
        desplazamientoY = velocidadY * Time.deltaTime;

        Vector3 nuevaPosicion = transform.position + new Vector3(movimientoHorizontal * desplazamientoX, movimientoVertical * desplazamientoY, 0);

        transform.position = nuevaPosicion;

        Vector3 posicionActual = transform.position;

        posicionActual.x = Mathf.Clamp(posicionActual.x, minX, maxX);

        posicionActual.y = Mathf.Clamp(posicionActual.y, minY, maxY);

        transform.position = posicionActual;
    }
    public void Disparo()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > TiempoDisparo + 0.3F)
        {
            posicionDisparo(0.3f, 0.3f);
            posicionDisparo(-0.3f, 0.3f);
            TiempoDisparo = Time.time;

        }
         
        

        
    }
    private void onTriggerEnter2D (Collider2D objecteTocat)
    {
        if (objecteTocat.tag == "Numero")
        {
            Destroy(gameObject);
        }
    }
}

