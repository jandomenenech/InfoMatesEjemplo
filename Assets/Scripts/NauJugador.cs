using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NauJugador : MonoBehaviour
{
    public float velocidad = 1.0f;
    public float velocidadY = 1.0f;
    private Camera mainCamera;
    private float minX, maxX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        CalcularLimitesDeCamara();
    }

    // Update is called once per frame
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
}

