using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1Animations : MonoBehaviour
{
    private Animator animacion;

    private float waitTime = 0.8f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
        //Hacer invisible el segundo modelo de la animación:
        transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Check if we have reached beyond 2 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
        if (timer > waitTime)
        {   
            timer = 0.0f;
            if(transform.GetChild(0).gameObject.activeSelf == true)
            {
                //animacion.SetBool("toAnimation_2", true);
                //Aquí hace invisible child[0] y hace visible child[1]
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
            }else{
                //animacion.SetBool("toAnimation_2", false);
                //Aquí hace invisble child[1] y hace visible child[0]
                transform.GetChild(1).gameObject.SetActive(false);
                transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}
