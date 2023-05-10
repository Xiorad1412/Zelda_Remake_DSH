using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEspada : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter() 
    {
        yield return new WaitForSeconds(1);
        Object.Destroy(this.gameObject);
    }


}
