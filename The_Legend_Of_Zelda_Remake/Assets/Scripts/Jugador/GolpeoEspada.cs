using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolpeoEspada : MonoBehaviour
{
    //Esta variable guarda el tiempo que se debe superar para poder dar el siguiente espadazo.
    float proximoEspadazo = 0.0f;


    //Esta variable guarda el tiempo que existe entre espadazo y espadazo.
    float tiempoEspadazo = 0.3f;


    //Esta variable guarda el gameObject que se instanciará cuando se de un espadazo (la espada).
    public GameObject espada;


    //Esta variable guarda el prefab de la espada.
    private GameObject espadazo;


    //De aqui saldrá la espda
    Transform salida;


    //Al inicio se toma el gameObject de donde va a surgir la espada
    void Start()
    {
        salida = gameObject.transform.GetChild(6).transform;
    }


    /*Cada vez que se pulsa el boton y ha pasado el tiempo deseado, se instancia una espada (Esto hace que se active "DestruirEspada").
    Asimismo se genera un mensaje para indicar que se ha instanciado una espada.*/
    void Update()
    {
        
        if (Time.time >= proximoEspadazo && Input.GetKey (KeyCode.P))
        {
            linkAnimations.changeActionToAttacking();
            proximoEspadazo = Time.time + tiempoEspadazo;
            espadazo = Instantiate(espada, salida.position, salida.rotation);
            Debug.Log("Espada");
        }
    }
    
}
