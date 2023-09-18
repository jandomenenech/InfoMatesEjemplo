using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public Rigidbody2D body;
    public ControladorDeDisparo disparo;
    public float velocitat;

    // Start is called before the first frame update
    void Start()
    {
        body= GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = Vector3.right * velocitat;
        
    }
    public void DestruirAlien()
    {
        Destroy(gameObject);
    }


}
