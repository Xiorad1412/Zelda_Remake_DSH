using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    //El jugador al que seguira
    public Transform player;

    //La velocidad de movimiento de la camara
    public float smoothspeed;

    /*Esta variables muestran la posicion en la que se encuentra el jugador y 
    la posicion a la que se ira moviendo la camara en cada momento respectivamente*/
    private Vector3 targetPos, newPos;

    //Estos vectores ponen los limites a los que se puede mover la camara
    public Vector3 minPos, maxPos;


    //Esta funcion hace que la camara vaya siguiendo al jugador
    void LateUpdate() 
    {
        //Si no esta en la misma posicion del jugador se mueve
       if (transform.position != player.position)
       {
            targetPos = player.position;

            Vector3 Limites = new Vector3 
            (
                Mathf.Clamp(targetPos.x, minPos.x, maxPos.x),
                Mathf.Clamp(targetPos.y, minPos.y, maxPos.y),
                Mathf.Clamp(targetPos.z, minPos.z, maxPos.z)
            );

            newPos = Vector3.Lerp(transform.position, Limites, smoothspeed);
            transform.position = newPos;
            
       } 
    }
}
