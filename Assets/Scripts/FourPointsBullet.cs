using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourPointsBullet /* Três pontos na verdade */ : MonoBehaviour
{
    public Transform pontoA;
    public Transform pontoB;
    public Transform pontoC;
    private Transform pontoD; // <--- Sem utilidade agora, mas manterei para quando for criar um de 4 pontos.
    public float Speed = 1;

    private float t = 0f;
    private bool indo = true;

    void Update()
    {
        t += Speed * Time.deltaTime;

        transform.position = Vector3.Lerp(
            indo ? pontoA.position : pontoB.position,
            indo ? pontoB.position : pontoC.position,      
            t
        );

        if (t >= 1f)
        {
            t = 0f;
            indo = !indo;
        }
       
    }
}
