using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plantar : MonoBehaviour
{
    private bool dentrodelatierra;
    private bool semillaplantada;
    
    public Inventario inventario;
    private Cultivo cultivo;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventario = player.GetComponent<Inventario>();
        cultivo = GetComponent<Cultivo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dentrodelatierra)
        {
            if (!semillaplantada && inventario.semilla > 0)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    plantar();
                }
            }
            if (cultivo.yacrecio)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    cosechar();
                }
            }
        }
    }

    void plantar()
    {
        inventario.semilla--;
        semillaplantada = true;
        cultivo.crecimiento();
    }

    void cosechar()
    {
        inventario.cultivo++;
        semillaplantada = false;
        cultivo.yacrecio = false;
        cultivo.crecio.SetActive(false);
        cultivo.sincrecer.SetActive(true);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentrodelatierra = true;
        }   
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentrodelatierra = false;
        }
    }
}
