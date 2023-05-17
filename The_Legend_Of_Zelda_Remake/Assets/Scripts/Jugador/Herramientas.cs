using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Herramientas : MonoBehaviour
{
    float proximaAccion = 0.0f;
    float tiempoAccion = 0.3f;
    
    private int opcion = 0;
    private const int numHerramientas = 4;

    private bool bombaexplota = false;

    //Parametro que guarda el prefab bomba
    public GameObject Bomba;
    //Parametro que crea la bomba
    private GameObject bombazo;


    public GameObject Exp;

    private GameObject Explosion;

    Transform salida;

    Transform bomb_position;

    //Se toma el gameObject del que surgira la herramienta
    void Start()
    {
        salida = gameObject.transform.GetChild(0).transform;
    }



    //En funcion de la opcion pulsada se activa una herramienta u otra
    void Update()
    {
        //Con esos botones se puede cambiar de arma
        if (Input.GetKey(KeyCode.J))
        {
            opcion = Math.Abs(--opcion % 4);
        }

        if (Input.GetKey(KeyCode.K))
        {
            opcion = Math.Abs(++opcion % 4);
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

        if (Time.time >= proximaAccion && Input.GetKey (KeyCode.O))
        {
            switch (opcion)
            {
                case 0: //proximaAccion = Time.time + tiempoAccion; 
                        //bombazo = Instantiate(Bomba, salida.position, salida.rotation);
                        break;
            }

        }
    }
    
}
