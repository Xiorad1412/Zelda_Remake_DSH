using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movmientojugador : MonoBehaviour
{
    public float velocidad;

    private Rigidbody rb;

    private int rotacion = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*En funcion de los botones que pulse se mueve a una direccion u otra, se hace con varios ifs para hacer que solo se
    pueda mover en una direccion a la vez, como en el juego */
    void Update()
    {
        //Se mueve a la izquierda
        if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
        {
            transform.Translate(-Vector3.back * velocidad * Time.deltaTime); 
            if (rotacion%360 != 90)
            {   
                transform.localRotation = Quaternion.Euler(1,-90,1);
                rotacion = 90;
            }
        
        }

        //Se mueve a la derecha
        else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
        {
            transform.Translate(-Vector3.back * velocidad * Time.deltaTime);   
            if (rotacion%360 != 270)
            {   
                transform.localRotation = Quaternion.Euler(1,90,1);
                rotacion = 270;
            }

        }

        //Se mueve hacia adelante
        else if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) 
        {
            transform.Translate(-Vector3.back * velocidad * Time.deltaTime);
            if (rotacion%360 != 0)
            {   
                transform.localRotation = Quaternion.Euler(1,0,1);
                rotacion = 0;
            }
        }

        //Se mueve hacia atras
        else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) 
        {
            transform.Translate(-Vector3.back * velocidad * Time.deltaTime);  
            if (rotacion%360 != 180)
            {   
                transform.localRotation = Quaternion.Euler(1,180,1);
                rotacion = 180;
            } 
        }  
    }
}
