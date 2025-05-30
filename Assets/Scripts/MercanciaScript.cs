using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio = 10;
    public DineroManager dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //restar precio al dinero del player
            dineroManager.UpdateMoney(-precio);
            Destroy(gameObject);
        } 
    }
}
