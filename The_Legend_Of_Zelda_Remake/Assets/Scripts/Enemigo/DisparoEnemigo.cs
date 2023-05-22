using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{

    /*Esta variable muestra el momento en el que el enemigo podra realizar el proximo disparo.
    Se ira actualizando cada vez que dispare*/
    float proximoDisparo = 0.0f;

    //Este es el tiempo entre disparos
    float tiempoDisparo = 0.3f;

    //Este es el gameObject que diparara
    public GameObject disparo;

    //De aqui saldrá el disparo
    Transform salida;

    //Al inicio guarda el objecto del que va a crearse el disparo
    void Start()
    {
        salida = gameObject.transform.GetChild(0).transform;
    }

    /*Este script se situa en un gameObject vacio, lo que hace es que cada vez que el gameObject colisione
    con el jugador, el enemigo crea un disparo, pero tiene que haber pasado el tiempo de proximoDisparo*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Time.time >= proximoDisparo)
        {
            proximoDisparo = Time.time + tiempoDisparo;
            GameObject nuevabala = Instantiate(disparo, salida.position, salida.rotation);
        }
    }
}
