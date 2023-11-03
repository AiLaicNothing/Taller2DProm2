using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compra : MonoBehaviour
{
    Inventario inventario;
    public int costoSemilla = 10;
    private bool DentroDeLaTienda;

    private void Start()
    {
       inventario = GetComponent<Inventario>(); 
    }
    public void Update()
    {
        if (DentroDeLaTienda)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ComprarSemillas(inventario.dinero);
            }
        }
    }
    public void ComprarSemillas(int dinero)
    {
        if (inventario.dinero >= costoSemilla)
        {
            inventario.ReduceMoney(costoSemilla);
            inventario.semilla++;
            
        }
        else
        {
            Debug.Log("No tienes suficiente dinero");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Tienda"))
        {
            DentroDeLaTienda = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Tienda"))
        {
            DentroDeLaTienda = false;
        }
    }


}
