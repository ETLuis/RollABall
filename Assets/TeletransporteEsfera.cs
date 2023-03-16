using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeletransporteEsfera : MonoBehaviour
{

    public float minY; // El valor de Y mínimo en el que el objeto se teletransportará
    public Vector3 teleportPosition; // La posición a la que se teletransportará el objeto
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY) {
            transform.position = teleportPosition;
        }

    }
    

}
