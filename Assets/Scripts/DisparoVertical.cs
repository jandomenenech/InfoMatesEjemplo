using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoVertical : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    public float speed = 20f;

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
