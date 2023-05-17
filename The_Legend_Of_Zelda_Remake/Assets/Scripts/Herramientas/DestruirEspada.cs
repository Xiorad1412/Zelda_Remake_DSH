using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEspada : MonoBehaviour
{
    // Cada vez que se instancia una espada en "GolpeoEspada" se inicia un contador
    private void Awake()
    {
        StartCoroutine(waiter());
    }

    //Cuando pase el tiempo deseado se destruye la espada
    IEnumerator waiter() 
    {
        yield return new WaitForSeconds(0.15f);
        Object.Destroy(this.gameObject);
    }


}
