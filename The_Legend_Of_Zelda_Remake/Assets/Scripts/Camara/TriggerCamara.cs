using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamara : MonoBehaviour
{
    public Vector3 newCamPos, newPlayerPos;

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
        }
    }

}
