using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObjectScript : MonoBehaviour
{
    public float daño = -10f;
    public HealthManagerScript healthManager;

    private void Start()
    {
        healthManager = FindObjectOfType<HealthManagerScript>();
    } 

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthManager.UpdateHealth(daño);
        } else {
            Debug.Log("NO toco a un jugador");
        }
    }
}
