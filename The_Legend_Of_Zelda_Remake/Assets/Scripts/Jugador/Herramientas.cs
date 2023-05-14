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

    //Parametro que guarda el objecto bomba
    public GameObject Bomba;
    //Parametro que crea la bomba
    private GameObject bombazo;

    Transform salida;

    // Start is called before the first frame update
    void Start()
    {
        salida = gameObject.transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            opcion = Math.Abs(--opcion % 4);
        }

        if (Input.GetKey(KeyCode.K))
        {
            opcion = Math.Abs(++opcion % 4);
        }

        //Parte de Bomba
        if (Time.time >= proximaAccion && Input.GetKey (KeyCode.O))
        {
            proximaAccion = Time.time + tiempoAccion;

            if (bombaexplota == false)
            {
                bombazo = Instantiate(Bomba, salida.position, salida.rotation);
                bombaexplota = true;
            }

            else 
            {
                Destroy(bombazo);
                bombaexplota = false;
                //Falta hacer que haga daño
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
