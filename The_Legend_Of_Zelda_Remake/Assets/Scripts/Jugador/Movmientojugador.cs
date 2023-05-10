using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movmientojugador : MonoBehaviour
{
    public float velocidad;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);    
        }
        else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
        transform.Translate(-Vector3.left * velocidad * Time.deltaTime);   
        }
        else if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
        transform.Translate(-Vector3.back * velocidad * Time.deltaTime);
        }
        else if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
        transform.Translate(Vector3.back * velocidad * Time.deltaTime);  
        }  
    }
}
