using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Herramientas : MonoBehaviour
{
    //Esta variable guarda el momento en el que se puede hacer la proxima acción.
    float proximaAccion = 0.0f;


    //Esta variable guarda el tiempo entre acción y acción.
    float tiempoAccion = 0.3f;
    
    //Esta variable guarda la herramienta seleccionada.
    private int opcion = 0;


    //Esta herramienta guarda el numero de herramientas totales.
    private const int numHerramientas = 1;


    //Esta variable sirve para saber si la bomba está colocada o no (La bomba se activa al 
    //pulsar el botón de acción una vez colocada)
    private bool bombaexplota = false;


    //Esta variable guarda el prefab bomba.
    public GameObject Bomba;


    //Esta variable instanciará las bombas.
    private GameObject bombazo;


    //Esta variable guarada el prefab de la explosion de la bomba.
    public GameObject Exp;


    //Esta variable instanciará las explosiones.
    private GameObject Explosion;


    //Esta variable guarda el gameObject del que saldrán las herramientas.
    Transform salida;

    //Esta variable guarda la posición de la bomba cuando se coloca.
    Transform bomb_position;


    //Se toma el gameObject del que surgira la herramienta
    void Start()
    {
        salida = gameObject.transform.GetChild(5).transform;
    }



    //En funcion de la opcion pulsada se activa una herramienta u otra
    void Update()
    {
        //Con esos botones se puede cambiar de arma
        if (Input.GetKey(KeyCode.J))
        {
            opcion = Math.Abs(--opcion % numHerramientas);
        }

        if (Input.GetKey(KeyCode.K))
        {
            opcion = Math.Abs(++opcion % numHerramientas);
        }


        //Herramienta bomba, si se pulsa el boton de accion y ha pasado el suficiente tiempo se realiza la accion de la bomba
        if (Time.time >= proximaAccion && Input.GetKey (KeyCode.O))
        {
            proximaAccion = Time.time + tiempoAccion;

            //Si no hay ninguna bomba colocada, se coloca la bomba
            if (bombaexplota == false)
            {
                bombazo = Instantiate(Bomba, salida.position, salida.rotation);
                bombaexplota = true;
                bomb_position = bombazo.transform;
            }

            //Si hay una bomba colocada esta explota
            else 
            {
                Destroy(bombazo);
                bombaexplota = false;
                Explosion = Instantiate(Exp,bomb_position.position, bomb_position.rotation);
            }
        }


        /*Este bloque podría ser utilizado en caso de que se quieran añadir más herramientas
        que solo tengan un funcionamiento (a diferencia de la bomba)*/

        if (Time.time >= proximaAccion && Input.GetKey (KeyCode.O))
        {
            switch (opcion)
            {
                
            }

        }
    }
    
}
