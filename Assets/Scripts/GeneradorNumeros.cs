using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNumeros : MonoBehaviour
{
    public GameObject _PrefabNumero;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarNumero", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void GenerarNumero()
    {
        GameObject numero = Instantiate(_PrefabNumero);
        Vector2 costatSuperiorDret = Camera.main.ViewportToWorldPoint(new Vector2(1f, 1f));
        Vector2 costatInferiorEsquerra = Camera.main.ViewportToWorldPoint(new Vector2(0f, 0f));

        numero.transform.position = new Vector2(
            Random.Range(costatInferiorEsquerra.x, costatSuperiorDret.x), costatSuperiorDret.y);


    }
}

