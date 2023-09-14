using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoVertical : MonoBehaviour
{
    public GameObject proyectilPrefab; // El prefab del proyectil que dispararemos.
    public Transform puntoDeDisparo; // El punto desde donde se disparará el proyectil.
    public float velocidadProyectil = 5.0f; // La velocidad del proyectil vertical.

    void Update()
    {
        // Verificar si el script está activado.
        if (enabled)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Si se presiona la tecla de espacio, dispara el proyectil verticalmente.
                DispararVerticalmente();
            }
        }
    }

    public void DispararVerticalmente()
    {
        // Instanciar un proyectil en la posición de disparo.
        GameObject nuevoProyectil = Instantiate(proyectilPrefab, puntoDeDisparo.position, Quaternion.identity);

        // Aplicar velocidad vertical al proyectil.
        Rigidbody2D rbProyectil = nuevoProyectil.GetComponent<Rigidbody2D>();
        if (rbProyectil != null)
        {
            rbProyectil.velocity = Vector2.up * velocidadProyectil;
        }
    }
}
