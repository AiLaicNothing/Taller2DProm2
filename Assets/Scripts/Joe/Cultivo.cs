using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cultivo : MonoBehaviour
{
    public float tiempoencrecer;
    public float tiempoactual;

    public bool yacrecio;

    public void crecimiento()
    {
        if (Time.time - tiempoactual < tiempoencrecer)
        {
            return;
            yacrecio = true;
        }
        tiempoactual = Time.time;
    }

}
 

