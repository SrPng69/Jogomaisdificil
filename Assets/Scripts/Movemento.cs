using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Movemento : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 Movimento;

    void Update()
    {    
       Movimento.x = Input.GetAxisRaw("Horizontal");
        Movimento.y = Input.GetAxisRaw("Vertical");

        Movimento = Movimento.normalized;

        PararMovimentoCasoSairDaTela();
    }

    private void FixedUpdate()
    {
        transform.position += (Vector3)(Movimento * moveSpeed * Time.fixedDeltaTime);
    }

    private void PararMovimentoCasoSairDaTela()
    {
        if (transform.position.x < -9f || transform.position.x > 9f)
        {
            Movimento.x = 0f;
        }

        if (transform.position.y < -5.1f || transform.position.y > 5.1f)
        {
            Movimento.y = 0f;
        }
    }
}