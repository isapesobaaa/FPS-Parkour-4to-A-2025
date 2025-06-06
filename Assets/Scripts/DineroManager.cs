using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DineroManager : MonoBehaviour
{

    public float playerMoney;
    public TextMeshProUGUI moneyText;

    public void UpdateMoney(float amount)
    {
        if (playerMoney + amount < 0)
        {
            //impedir compra
        }
        else
        {
            playerMoney += amount;
            moneyText.text = playerMoney.ToString();
        }
    }
}
