using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float puntuacion= 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 30, 45) * Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //Aumenta la puntación del texto en 1
        puntuacion = puntuacion + 1;
        Score.AddPoints(1);
        Debug.Log("La puntuación es: " + puntuacion);
        other.gameObject.SetActive(false);

    }
}
