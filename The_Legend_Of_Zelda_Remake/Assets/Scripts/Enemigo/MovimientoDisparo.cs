using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDisparo : MonoBehaviour
{
    //Esta variable representa la velocidad del disparo
    public float velocidad = 5.0f;

    //Esta funcion va actualizando la posisicion del disparo
    void Update()
    {
        float movDistancia = Time.deltaTime * velocidad;
        transform.Translate(Vector3.up * movDistancia);
    }

    //Cuando el disparo colisiona con el jugador desaparece el disparo
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Object.Destroy(this.gameObject);
        }
    }
}
