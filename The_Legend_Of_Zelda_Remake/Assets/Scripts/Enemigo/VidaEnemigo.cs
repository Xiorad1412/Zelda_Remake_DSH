using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VidaEnemigo : MonoBehaviour
{
    public float Vida = 1.0f;
    public float maxVida = 1.0f; 

    public UnityEvent hesidoTocado;
    public UnityEvent estoyMuerto;

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
