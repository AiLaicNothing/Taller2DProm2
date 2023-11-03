using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccion : MonoBehaviour
{
    public float interactionDistance = 2f;
    public LayerMask interactableLayer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractWithNearbyObjects(); // Cuando precionas E vas a InteractWithNearbyObjects que es lo que esta justo abajo 
        }
    }

    private void InteractWithNearbyObjects()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, interactionDistance, interactableLayer); // Comprueba si hay algo interactuable en la capa interactuable para ello toodo lo que se podra interactuar debe de estar en un capa llamada interactableLayer

        foreach (Collider collider in hitColliders)
        {
            if (collider.CompareTag("Cultivo")) // Si es que toca un collider con el tag cultivo hace 
            {
                //CultivoScript cultivo = collider.GetComponent<CultivoScript>(); // CultivoScript es el nombre del script que controla el cultivi xd luego lo cambian 

                //if (cultivo.IsReadyToHarvest())
                {
                    // Recoge el cultivo y agrégalo al inventario del jugador. esto solo funciona con el scrip origianl 
                    //AddToInventory(cultivo);
                    Destroy(collider.gameObject);
                }
            }
            else if (collider.CompareTag("Tienda")) // Si es que toca un collider con tag tienda hace
            {
                // Vende todo lo que tienes en el inventario y recibe dinero a cambio.
                //SellAllInInventory();
            }
        }
    }

    //private void AddToInventory(CultivoScript cultivo)
    //{
        // Agrega el cultivo al inventario del jugador.
        // Aqui agregas el scrip que envia todo haci el inventario
    //}

    private void SellAllInInventory()
    {
        // Vende todos los cultivos en el inventario y recibe dinero a cambio.
        // Actualiza la cantidad de dinero del jugador y vacía el inventario.
    }
}
