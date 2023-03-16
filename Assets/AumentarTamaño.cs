using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarTamaño : MonoBehaviour
{
    public GameObject objectToCollideWith; // Objeto con el que el jugador debe chocar para cambiar de tamaño
    public float sizeIncreaseAmount = 0.5f; // Cantidad en la que se incrementará el tamaño

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == objectToCollideWith) // Si el objeto colisiona con el objeto especificado
        {
            Debug.Log("Objeto colisionó con " + objectToCollideWith.name); // Verificar si se detectó la colisión
            transform.localScale += new Vector3(sizeIncreaseAmount, sizeIncreaseAmount, sizeIncreaseAmount); // Incrementar el tamaño
            Debug.Log("Nuevo tamaño: " + transform.localScale); // Verificar si se incrementó el tamaño
        }
    }
}
