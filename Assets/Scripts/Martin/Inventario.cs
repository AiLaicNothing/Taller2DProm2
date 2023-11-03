using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public int semilla;
    public int cultivo;

    public int dinero = 0;

    public DineroUI dineroUI;

    private void Start()
    {
        dineroUI.ShowMoney(dinero);
    }
    private void Update()
    {
        dineroUI.ShowMoney(dinero);
    }

    public void ReduceMoney(int costo)
    {
        dinero -= costo;
    }
}
