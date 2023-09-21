using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNumeros : MonoBehaviour
{
    public GameObject prefabNumero;
    
    void Start()
    {
        InvokeRepeating("generarNumero", 1f,3f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void generarNumero()
    {
        GameObject numero = Instantiate(prefabNumero);
        Vector2 costatSuperiorDret = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 cosratInferiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        numero.transform.position = new Vector2(
           Random.Range(cosratInferiorEsquerra.x, costatSuperiorDret.x),
           costatSuperiorDret.y);
    }
}
