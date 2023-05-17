using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolpeoEspada : MonoBehaviour
{
    float proximoEspadazo = 0.0f;
    float tiempoEspadazo = 0.3f;
    public GameObject espada;

    private GameObject espadazo;

    Transform salida;

    //Al inicio se toma el gameObject de donde va a surgir la espada
    void Start()
    {
        salida = gameObject.transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Cada vez que se pulsa el boton y ha pasado el tiempo deseado, se instancia una espada (Esto hace que se active "DestruirEspada")
        if (Time.time >= proximoEspadazo && Input.GetKey (KeyCode.P))
        {
            proximoEspadazo = Time.time + tiempoEspadazo;
            espadazo = Instantiate(espada, salida.position, salida.rotation);
            Debug.Log("Espada");
        }
    }
    
}
