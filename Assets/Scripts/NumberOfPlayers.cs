using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/* 
 !!!!!!!!!KEYS GAME MANAGER!!!!!!!!!
*/
public class NumberOfPlayers : MonoBehaviour
{
    public static NumberOfPlayers instance;

    public int Keys = 0;
    public int keysNecessarias;
    public bool progressao = false;
    public GameObject nextLevelPortal;

    private void Start()
    {
        nextLevelPortal.SetActive(false);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
         else
         {
            Destroy(gameObject);
         }
    }

    public void AddKey()
    {
        Keys++;

        if (Keys == keysNecessarias)
        {
            progressao = true;
        }
    }
}