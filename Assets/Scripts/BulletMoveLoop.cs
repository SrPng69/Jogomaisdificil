using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveLoop : MonoBehaviour
{
    public Transform pontoA;
    public Transform pontoB;
    public float Speed = 1f;

    private float t = 0f;
    private bool indo = true;

    void Update()
    {
        t += Speed * Time.deltaTime;

        transform.position = Vector3.Lerp(
            indo ? pontoA.position : pontoB.position,
            indo ? pontoB.position : pontoA.position,
            t
        );

        if (t >= 1f)
        {
            t = 0f;
            indo = !indo;
        }
    }
}
