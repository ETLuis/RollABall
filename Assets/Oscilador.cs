using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilador : MonoBehaviour
{
    public float amplitude = 1f; // amplitud de la oscilación
    public float period = 1f; // periodo de la oscilación
    public Vector3 axis = Vector3.up; // eje de oscilación

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float angle = Time.timeSinceLevelLoad / period * 2 * Mathf.PI;
        Vector3 offset = amplitude * Mathf.Sin(angle) * axis;
        transform.position = startPosition + offset;
    }
}
