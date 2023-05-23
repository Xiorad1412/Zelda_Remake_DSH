using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    //Esta variable guarda cuando se realizó el último movimiento.
    private float latestDirectionChangeTime;


    //Esta variable guarda el tiempo que debe pasar entre un desplazamiento y otro.
    private readonly float directionChangeTime = 1f;


    //Esta variable guarda la velocidad del enemigo.
    private float characterVelocity = 0f;


    //Esta variable guarda la distancia que se mueve el enemigo en cada desplazamiento.
    private Vector3 movementDirection;


    //Esta variable guarda el Rigidbody del enemigo
    Rigidbody enem_rigid;


    //Esta variable guarda la rotación del enemigo
    private int rotacion = 0;


    //Esta variable guarda un numero aleatorio que se generará cuando el enemigo se vaya a desplazar
    private int Aleatorio;

 
    /*Al inicio se guarda en enem_rigid el Rigidbody del enemigo, se pone latestDirectionChangeTime a 0 y 
    se calcula el primer movimiento.*/
    void Start()
    {
        enem_rigid = GetComponent<Rigidbody>();
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
    }


    /*Cada vez que se lanza esta funcion se genera un numero aleatorio entre 1 y 10 para determinar en que 
    direccion se moverá a continuación (Esto está hecho asi para parecerse al juego original).
    En función del numero generado se moverá en una dirección u otra. La distancia que se desplaza el enemigo
    también es aleatoria.*/
    void calcuateNewMovementVector()
    {
        Aleatorio = Random.Range(1,10);

        if (Aleatorio > 5)
        {
            movementDirection = new Vector3(Random.Range(-1.0f, 1.0f), 0, 0).normalized;
        }
        
        if (Aleatorio <= 5)
        {
            movementDirection = new Vector3(0, 0, Random.Range(-1.0f, 1.0f)).normalized;
        }
        
    }
 

    /*Cuando ha pasado el sufiente tiempo, el script hace que se genere un nuevo valor para movementDirection
    que hace que el enemigo se desplace cierta distancia. En caso de que se acabe de calcular ese valor el enemigo se desplaza.
    Si el movementDirection hace que el enemigo se mueva en una dirección en la que previamente no se estaba desplazando, 
    el enemigo se gira.*/
    void Update()
    {
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }

        //Rota a la izquierda.
        if (movementDirection.x < 0)
        {
            if (rotacion%360 != 180)
            {   
                transform.localRotation = Quaternion.Euler(0,180,0);
                rotacion = 180;
            } 
        }

        //Rota a la derecha.
        if (movementDirection.x > 0)
        {
            if (rotacion%360 != 0)
            {   
                transform.localRotation = Quaternion.Euler(0,0,0);
                rotacion = 0;
            }
        }

        //Rota hacia alante.
        if (movementDirection.z > 0)
        {
            if (rotacion%360 != 90)
            {   
                transform.localRotation = Quaternion.Euler(0,-90,0);
                rotacion = 90;
            }
        }

        //Rota hacia atras.
        if (movementDirection.z < 0)
        {
            if (rotacion%360 != 270)
            {   
                transform.localRotation = Quaternion.Euler(0,90,0);
                rotacion = 270;
            }
        }

        //El enemigo se desplaza.
        enem_rigid.MovePosition(transform.position + (movementDirection * Time.deltaTime * characterVelocity));
 
    }
}
