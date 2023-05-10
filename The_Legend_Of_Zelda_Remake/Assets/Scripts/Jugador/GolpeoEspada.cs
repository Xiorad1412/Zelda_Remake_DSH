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

    // Start is called before the first frame update
    void Start()
    {
        salida = gameObject.transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= proximoEspadazo && Input.GetKey (KeyCode.P))
        {
            proximoEspadazo = Time.time + tiempoEspadazo;
            espadazo = Instantiate(espada, salida.position, salida.rotation);

        }
    }
    
}
