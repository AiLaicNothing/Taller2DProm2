using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venta : MonoBehaviour
{
    private Inventario inventario;

    [SerializeField] private int valorDeItemVendido;

    public bool zonaDeVenta;
    // Start is called before the first frame update
    void Start()
    {
        inventario = GetComponent<Inventario>();
    }

    // Update is called once per frame
    void Update()
    {
        if (zonaDeVenta)
        {
            if(Input.GetKeyDown(KeyCode.E)) 
            { 
                if(inventario.cultivo > 0)
                {
                    inventario.cultivo--;
                    inventario.dinero += valorDeItemVendido;
                }
                else
                {
                    Debug.Log("No tienes nada para vender");
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mercado"))
        {
            zonaDeVenta = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Mercado"))
        {
            zonaDeVenta = false;
        }
    }
}
