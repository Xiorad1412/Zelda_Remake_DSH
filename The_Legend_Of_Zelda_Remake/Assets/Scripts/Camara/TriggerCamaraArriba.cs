using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamaraArriba : MonoBehaviour
{
    public Vector3 newCamPos, newPlayerPos;

    public TriggerCamaraAbajo triggerAbajo;

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

            triggerAbajo.enabled = false;
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter() 
    {
        yield return new WaitForSeconds(3);
        triggerAbajo.enabled = true;
    }

}
