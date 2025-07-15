using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyTextMesh;
    public TextMeshProUGUI healthTextMesh;

    public void UpdateMoney(string amount) {
        moneyTextMesh.text = amount;
    }

    public void UpdateHealthText(string points)
    {
        healthTextMesh.text = points;
    }
}

