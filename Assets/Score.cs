using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;        // La puntuación actual del jugador.
    public Text scoreText;          // El objeto Text utilizado para mostrar la puntuación.

    void Start ()
    {
        // Inicializa la puntuación en cero.
        score = 0;
    }

    void Update ()
    {
        // Actualiza el objeto Text con la puntuación actual.
        scoreText.text = "Score: " + score;
    }

    // Método utilizado para aumentar la puntuación del jugador.
    public static void AddPoints (int pointsToAdd)
    {
        score += pointsToAdd;   // Añade los puntos especificados a la puntuación actual.
    }

}
