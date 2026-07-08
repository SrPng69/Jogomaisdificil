using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLogic : MonoBehaviour
{
    public string Level1;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            SceneManager.LoadScene(Level1);
        }
    }
}
