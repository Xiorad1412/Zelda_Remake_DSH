using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoEnemigo : MonoBehaviour
{
    //Esta funcion sirve como prueba para ver que el enemigo ha sido golpeado por algo
    public void hesidoTocadoINSIDE()
    {
        Debug.Log("ENEMIGO-ME HAN DADO");
    }


    //Cuando el enemigo se golpea y se queda sin vida este desaparece
    public void estoyMuertoINSIDE()
    {
        Debug.Log("ENEMIGO-ESTOY MUERTO");
        Destroy(gameObject);
    }
}
