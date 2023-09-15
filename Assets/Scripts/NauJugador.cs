using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    
    public float velocidad;
    public float velocidadY;
    private Camera mainCamera;
    private float minX, maxX, minY, maxY;
    public GameObject bala;
    public float TiempoDisparo;

    void Start()
    {
        mainCamera = Camera.main;
        CalcularLimitesDeCamara();
    }


    void Update()
    {
        float desplazamiento = velocidad * Time.deltaTime;
        float desplazamientoY = velocidadY * Time.deltaTime;

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 nuevaPosicion = transform.position + new Vector3(movimientoHorizontal * desplazamiento, movimientoVertical*desplazamientoY, 0);
      

        transform.position = nuevaPosicion;

        Vector3 posicionActual = transform.position;

        posicionActual.x = Mathf.Clamp(posicionActual.x, minX, maxX);

        posicionActual.y = Mathf.Clamp(posicionActual.y, minY, maxY);

        transform.position = posicionActual;

        if (Input.GetKey(KeyCode.Space) && Time.time > TiempoDisparo+0.3F)
        {
            shoot();
            TiempoDisparo = Time.time;
                if (Time.time > TiempoDisparo +2F)
            {
                Destroy(bala);
            }
            
        }
    }

    void CalcularLimitesDeCamara()
    {
        Vector3 esquinaInferiorIzquierda = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 esquinaSuperiorDerecha = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, 0)); 

        minX = esquinaInferiorIzquierda.x;
        maxX = esquinaSuperiorDerecha.x;
        minY = esquinaInferiorIzquierda.y;
        maxY = esquinaSuperiorDerecha.y;
    }
    public void shoot()
    {
        GameObject bullet = Instantiate(bala, transform.position, Quaternion.identity);
    }
}

