using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject seguidor;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = seguidor.transform.position;
    }
}
