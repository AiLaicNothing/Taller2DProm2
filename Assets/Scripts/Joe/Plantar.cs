using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plantar : MonoBehaviour
{
    private bool dentrodelatierra;
    private bool semillaplantada;
    
    public Inventario inventario;
    public Cultivo cultivo;
    // Start is called before the first frame update
    void Start()
    {
        inventario = GetComponent<Inventario>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dentrodelatierra)
        {
            if (!semillaplantada)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    inventario.semilla--;
                    semillaplantada = true;
                    cultivo.crecimiento();
                }
            }
            if (cultivo.yacrecio)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    inventario.cultivo++;
                    semillaplantada = false;
                }
            }
        }
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
