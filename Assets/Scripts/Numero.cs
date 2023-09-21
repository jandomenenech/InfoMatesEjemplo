using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Numero : MonoBehaviour
{
    private float velocitat;
    // Start is called before the first frame update
    void Start()
    {
        velocitat = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 novaPos = transform.position;
        novaPos.y = novaPos.y - velocitat * Time.deltaTime;
        transform.position= novaPos;
        DestruirNumero();
    }
    private void DestruirNumero()
    {
        Vector2 costatInferiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2 (0,0));
        if ( transform.position.y<= costatInferiorEsquerra.y) {

        Destroy(gameObject);

        }
    }
}

