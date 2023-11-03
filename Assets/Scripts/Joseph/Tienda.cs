using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tienda : MonoBehaviour
{
    public Text dineroText;
    public int costoSemilla;
    public GameObject semilla;
    public Transform puntoSpawnSemilla;
    public Inventario inventario;
    public int precioVenta;

    private int dineroJugador;

    void Start()
    {
        dineroJugador = 100;
        ActualizarDineroUI();
    }

    public void ComprarSemilla()
    {
        if (dineroJugador >= costoSemilla)
        {
            dineroJugador -= costoSemilla;
            ActualizarDineroUI();

            // Añadir la semilla al inventario del jugador 
        }
        else
        {
            Debug.Log("No tienes suficiente dinero para comprar esta semilla.");
        }
    }

    public void VenderSemilla()
    {
        //if (inventario.TieneItem(semilla))
        //{
        //    dineroJugador += precioVenta;
        //    ActualizarDineroUI();

        //    // Eliminar una semilla del inventario del jugador
        //    inventario.RemoverItem(semilla);
        //}
        //else
        //{
        //    Debug.Log("No tienes esta semilla en tu inventario para vender.");
        //}
    }

    void ActualizarDineroUI()
    {
        dineroText.text = "Dinero: " + dineroJugador.ToString();
    }
}
