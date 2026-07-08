using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourPointsBullet : MonoBehaviour
{
    public Transform pontoA;
    public Transform pontoB;
    public Transform pontoC;
    public Transform pontoD;
    public float Speed = 1;

    private float t = 0f;
    private bool indo = true;

    Vector3 inicio = Vector3.zero;
    Vector3 fim = Vector3.zero;

    private int etapa = 0;

    void Update()
    {
        switch (etapa)
        {
            case 0:
                inicio = pontoA.position;
                fim = pontoB.position;
                break;

            case 1:
                inicio = pontoB.position;
                fim = pontoC.position;
                break;

            case 2:
                inicio = pontoC.position;
                fim = pontoD.position;
                break;

            case 3:
                inicio = pontoD.position;
                fim = pontoA.position;
                break;
        }

        transform.position = Vector3.Lerp(inicio, fim, t);

        if (t >= 1f)
        {
            t = 0f;
            etapa = (etapa + 1) % 4;
        }
    }
}
