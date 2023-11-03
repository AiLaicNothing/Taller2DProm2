using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float vel=5.0f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 mov = new Vector2(x, y).normalized*vel*Time.deltaTime;
        transform.Translate(mov);
    }
}
