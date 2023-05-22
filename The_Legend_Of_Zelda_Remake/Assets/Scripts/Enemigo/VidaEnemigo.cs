using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VidaEnemigo : MonoBehaviour
{
    //Estas variables guardan la vida actual del enemigo y la vida maxima respectivamente.
    public float Vida = 1.0f;
    public float maxVida = 1.0f; 

    //Estas variables son eventos que el script llamará en caso de que se lance la acción tocado.
    public UnityEvent hesidoTocado;
    public UnityEvent estoyMuerto;

    /*Esta función se lanza cuando una de las herramientas colisiona con el enemigo. Se decrementa su vida en 
    función de la fuerza aplicada y se llama a el evento hesidoTocado y si su vida es <= a 0 se lanza el evento estoyMuerto.*/
    void tocado(float fuerza)
    {
        //Acción de que me han dado
        Vida -= fuerza;
        hesidoTocado.Invoke();
        if(Vida <= 0)
        {
            //Acción de que me he muerto
            estoyMuerto.Invoke();
        }
    }
}
