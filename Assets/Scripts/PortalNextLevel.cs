using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLogic : MonoBehaviour
{
    public string nextLevel;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
