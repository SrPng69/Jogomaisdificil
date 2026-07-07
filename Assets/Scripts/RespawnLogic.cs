using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class RespawnLogic : MonoBehaviour
{
    public GameObject Player;
    public Transform pontoDeSpawn;

    private bool spawnado = false;

    void Update()
    {
        GameObject[] PlayerNUm = GameObject.FindGameObjectsWithTag("Player");

        if (PlayerNUm.Length == 0 && !spawnado)
        {
            Instantiate(Player, pontoDeSpawn.position, Quaternion.identity);
            spawnado = true;
        }

        if (PlayerNUm.Length > 0)
        {
            spawnado = false;
        }
    }
}
