using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoEspada : MonoBehaviour
{
    //Esta variable guarda el daño de la espada cada vez que golpee a un enemigo.
    public float valorHerida = 1.0f;


    /*Esta función se lanza cada vez que la espada colisiona con algo y si ese algo
    es un enemigo activa la función tocado con el valorHerida indicado. Adicionalmente 
    esto lanza un Log para indicar que ha colisionado con un enemigo.*/
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Enemigo"))
        {
            Debug.Log("he chocado con el enemigo");
            other.SendMessage("tocado", valorHerida, SendMessageOptions.DontRequireReceiver);
        }
    }
}
