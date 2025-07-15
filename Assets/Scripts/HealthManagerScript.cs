using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManagerScript : MonoBehaviour
{

    public float vida;
    public UIManager uiManager;

    private void Start()
    {
        uiManager.UpdateHealthText(vida.ToString());
    }
    public bool UpdateHealth(float points)
    {
        float newVida = vida + points;

        if (newVida < 0)
        {
            vida = 0f;
            uiManager.UpdateHealthText(vida.ToString());
            return false;
        }

        vida = newVida;
        uiManager.UpdateHealthText(vida.ToString());
        return true;
    }
}
