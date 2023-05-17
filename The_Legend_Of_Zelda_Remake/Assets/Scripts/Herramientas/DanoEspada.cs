using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoEspada : MonoBehaviour
{
    public float valorHerida = 1.0f;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Enemigo"))
        {
            Debug.Log("he chocado con el enemigo");
            other.SendMessage("tocado", valorHerida, SendMessageOptions.DontRequireReceiver);
        }
    }
}
