using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeDisparo : MonoBehaviour
{
    public DisparoVertical disparoVerticalScript;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Cuando se presiona la tecla de espacio, activa el script de disparo vertical.
            disparoVerticalScript.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            // Cuando se suelta la tecla de espacio, desactiva el script de disparo vertical.
            disparoVerticalScript.enabled = false;
        }
    }
}




