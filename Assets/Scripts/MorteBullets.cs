using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteBullets : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            MortesNumber.quant_Mortes++;
        }
    }
}
