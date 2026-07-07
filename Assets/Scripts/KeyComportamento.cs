using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyComportamento : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            NumberOfPlayers.instance.AddKey();
            Destroy(gameObject);
        }
    }
}