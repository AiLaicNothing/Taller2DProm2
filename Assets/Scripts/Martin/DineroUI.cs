using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.UI;

public class DineroUI : MonoBehaviour
{
    public TMP_Text TMP_Text;

    public void ShowMoney(int dinero)
    {
        TMP_Text.text = $"dinero: {dinero}";
    }
}
