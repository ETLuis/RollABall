using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desbloquear : MonoBehaviour
{
    public int scoreToHide = 3; // La puntuación que el jugador debe alcanzar para que el objeto desaparezca.
    private Renderer objectRenderer; // Referencia al componente Renderer del objeto.

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Score.score >= scoreToHide)
        {
            
            Destroy(gameObject);
        }
    }
    
    
}
