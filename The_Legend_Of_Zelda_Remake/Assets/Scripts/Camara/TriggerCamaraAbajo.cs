using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamaraAbajo : MonoBehaviour
{
    public Vector3 newCamPos, newPlayerPos;

    public TriggerCamaraArriba triggerArriba;

    ControladorCamara camControl;

    void Start()
    {
        camControl = Camera.main.GetComponent<ControladorCamara>();
    }


    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            camControl.minPos += newCamPos;
            camControl.maxPos += newCamPos;

            other.transform.position += newPlayerPos;

            triggerArriba.enabled = false;
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter() 
    {
        yield return new WaitForSeconds(3);
        triggerArriba.enabled = true;
    }

}
