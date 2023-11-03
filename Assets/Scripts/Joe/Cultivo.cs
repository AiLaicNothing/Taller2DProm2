using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cultivo : MonoBehaviour
{
    public float cooldown;

    public bool yacrecio;

    public GameObject sincrecer;
    public GameObject crecio;

    public void crecimiento()
    {
        StartCoroutine(TiempoDeEspera());
    }

    IEnumerator TiempoDeEspera()
    {
        yield return new WaitForSeconds(cooldown);
        yacrecio = true;
        sincrecer.SetActive(false);
        crecio.SetActive(true);
    }
    

}
 

