using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.3f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimiento = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movimiento.z = 1;
        }
        else if(Input.GetKey(KeyCode.S))
            {
            movimiento.z = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movimiento.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movimiento.x = -1;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            movimiento.y = 1;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            movimiento.y = -1;
        }


        Move(movimiento);

        void Move(Vector3 direcion)
        {
            transform.position += direcion.normalized * speed * Time.deltaTime;
        }
    }
}
