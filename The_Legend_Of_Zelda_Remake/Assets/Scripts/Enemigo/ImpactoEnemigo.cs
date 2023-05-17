using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactoEnemigo : MonoBehaviour
{

    public void hesidoTocadoINSIDE()
    {
        Debug.Log("ENEMIGO-ME HAN DADO");
    }

    public void estoyMuertoINSIDE()
    {
        Debug.Log("ENEMIGO-ESTOY MUERTO");
        Destroy(gameObject);
    }
}
