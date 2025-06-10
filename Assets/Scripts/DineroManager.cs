using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DineroManager : MonoBehaviour
{
    public UIManager uiManager;
    public float playerMoney;
    public TextMeshProUGUI moneyText;

    public bool UpdateMoney(float amount)
    {
        if (playerMoney + amount < 0)
        {
            //impedir compra
            return false;
        }
        else
        {
            playerMoney += amount;
            uiManager.UpdateMoney(playerMoney.ToString());
        }
        return true;
    }
}
