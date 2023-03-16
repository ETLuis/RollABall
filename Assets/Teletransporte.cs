using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;
    public GameObject ThePlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ThePlayer.transform.position = Target.transform.position;

    }
}
