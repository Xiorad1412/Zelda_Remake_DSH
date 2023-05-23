using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkAnimations : MonoBehaviour
{
    public enum Acciones{IDLE, RUNNING, ATTACKING};

    public static linkAnimations _instancia;

    private Animator animacionEspada;

    private float waitTimeIdle = 0.8f;
    private float waitTimeRunning = 0.1f;
    private float timerIdle = 0.0f;
    private float timerRunning = 0.0f;

    public static Acciones accionActual;

    void Awake(){
        if(linkAnimations._instancia == null){
            //Nunca se ha lanzado
            linkAnimations._instancia = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animacionEspada = transform.GetChild(4).gameObject.GetComponent<Animator>();

        //Establecer la acción actual a Idle
        accionActual = Acciones.IDLE;


        //Hacer invisible el segundo modelo de la animación, y los modelos de correr:
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timerIdle += Time.deltaTime;
        timerRunning += Time.deltaTime;
        
        /* Código de prueba:
        if(Input.GetKeyDown("space")){
            accionActual=Acciones.RUNNING;
        }
        if(Input.GetKeyDown(KeyCode.N)){
            accionActual=Acciones.IDLE;
        }
        if(Input.GetKeyDown(KeyCode.M)){
            accionActual=Acciones.ATTACKING;
        }*/

        switch(accionActual){

            case Acciones.IDLE:
                //Desactivar la animación de la espada si seguía activa
                animacionEspada.SetBool("toSwing", false);
                // Comprueba si han pasado los waitTimeIdle segundos.
                if (timerIdle > waitTimeIdle)
                {   
                    transform.GetChild(2).gameObject.SetActive(false);
                    transform.GetChild(3).gameObject.SetActive(false);
                    if(transform.GetChild(0).gameObject.activeSelf == false && transform.GetChild(1).gameObject.activeSelf == false){
                        transform.GetChild(0).gameObject.SetActive(true);
                    }timerIdle = 0.0f;
                    if(transform.GetChild(0).gameObject.activeSelf == true)
                    {
                        //Aquí hace invisible child[0] y hace visible child[1]
                        transform.GetChild(0).gameObject.SetActive(false);
                        transform.GetChild(1).gameObject.SetActive(true);
                    }else{
                        //Aquí hace invisible child[1] y hace visible child[0]
                        transform.GetChild(1).gameObject.SetActive(false);
                        transform.GetChild(0).gameObject.SetActive(true);
                    }
                }
                break;

            case Acciones.RUNNING:
                //Desactivar la animación de la espada si seguía activa
                animacionEspada.SetBool("toSwing", false);
                // Comprueba si han pasado los waitTimeRunning segundos.
                if (timerRunning > waitTimeRunning)
                {   

                    timerRunning = 0.0f;
                    //Condiciones puestas en cortocircuito para que si la primera es true (ciclo normal de la animación) no se evalúe la otra
                    if(transform.GetChild(3).gameObject.activeSelf == true || transform.GetChild(0).gameObject.activeSelf == true || transform.GetChild(1).gameObject.activeSelf == true)
                    {
                        //Aquí hace invisible child[0] o child[1] y hace visible child[2]
                        transform.GetChild(0).gameObject.SetActive(false);
                        transform.GetChild(1).gameObject.SetActive(false);
                        transform.GetChild(3).gameObject.SetActive(false);
                        transform.GetChild(2).gameObject.SetActive(true);
                    }else
                    {
                        //Aquí hace invisble child[3] y hace visible child[0]
                        transform.GetChild(2).gameObject.SetActive(false);
                        transform.GetChild(3).gameObject.SetActive(true);
                    }
                }
                break;
            case Acciones.ATTACKING:
                animacionEspada.SetBool("toSwing", true);
                break;
            default:
                Debug.Log("Ha habido un error con las acciones, la accion actual no existe");
                accionActual=Acciones.IDLE;
                break;


        }
    }

    public static void changeActionToIdle(){
        accionActual=Acciones.IDLE;
    }

    public static void changeActionToRunning(){
        accionActual=Acciones.RUNNING;
    }

    public static void changeActionToAttacking(){
        accionActual=Acciones.ATTACKING;
    }
}

