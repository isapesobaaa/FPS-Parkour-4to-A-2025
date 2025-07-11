using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManagerScript : MonoBehaviour
{

    public float vida = 100f;
    public UIManager uiManager;

    
    public bool UpdateHealth(float points)
    {
        float newVida = vida + points;

        if (newVida < 0)
        {
            vida = 0f;
            uiManager.UpdateHealthText(vida);
            return false;
        }

        vida = newVida;
        uiManager.UpdateHealthText(vida);
        return true;
    }
}
