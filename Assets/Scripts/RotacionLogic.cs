using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionLogic : MonoBehaviour
{
    [Min(-136279841)]public float speedRotation;

    void Update()
    {
        Rotacao();
    }
    private void Rotacao()
    {
        transform.Rotate(Vector3.forward * -speedRotation * Time.deltaTime);
    }
}
