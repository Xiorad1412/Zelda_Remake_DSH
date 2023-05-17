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
    pueda mover en una direccion a la vez, como en el juego.
    El parametro rotacion sirve para girar el personaje cuando se mueva para otra direccion*/
    void Update()
    {
        //Se mueve a la izquierda
        if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
        {
            transform.Translate(-Vector3.back * velocidad * Time.deltaTime); 
            if (rotacion%360 != 90)
            {   
                transform.localRotation = Quaternion.Euler(0,-90,0);
                rotacion = 90;
            }
        
        }

        //Se mueve a la derecha
        else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
        {
            transform.Translate(-Vector3.back * velocidad * Time.deltaTime);   
            if (rotacion%360 != 270)
            {   
                transform.localRotation = Quaternion.Euler(0,90,0);
                rotacion = 270;
            }

        }

        //Se mueve hacia adelante
        else if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) 
        {
            transform.Translate(-Vector3.back * velocidad * Time.deltaTime);
            if (rotacion%360 != 0)
            {   
                transform.localRotation = Quaternion.Euler(0,0,0);
                rotacion = 0;
            }
        }

        //Se mueve hacia atras
        else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) 
        {
            transform.Translate(-Vector3.back * velocidad * Time.deltaTime);  
            if (rotacion%360 != 180)
            {   
                transform.localRotation = Quaternion.Euler(0,180,0);
                rotacion = 180;
            } 
        }  
    }
}
