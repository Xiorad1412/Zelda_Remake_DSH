using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{

    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 1f;
    private float characterVelocity = 3f;
    private Vector3 movementDirection;
    Rigidbody enem_rigid;


    private int rotacion = 0;


    private int Aleatorio;
 
    void Start()
    {
        enem_rigid = GetComponent<Rigidbody>();
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
    }



    void calcuateNewMovementVector()
    {
        Aleatorio = Random.Range(1,10);
        //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
        if (Aleatorio > 5)
        {
            movementDirection = new Vector3(Random.Range(-1.0f, 1.0f), 0, 0).normalized;
        }
        
        if (Aleatorio <= 5)
        {
            movementDirection = new Vector3(0, 0, Random.Range(-1.0f, 1.0f)).normalized;
        }
        
    }
 
    void Update()
    {
        //if the changeTime was reached, calculate a new movement vector
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }


        if (movementDirection.x < 0)
        {
            if (rotacion%360 != 180)
            {   
                transform.localRotation = Quaternion.Euler(0,180,0);
                rotacion = 180;
            } 
        }


        if (movementDirection.x > 0)
        {
            if (rotacion%360 != 0)
            {   
                transform.localRotation = Quaternion.Euler(0,0,0);
                rotacion = 0;
            }
        }


        if (movementDirection.z > 0)
        {
            if (rotacion%360 != 90)
            {   
                transform.localRotation = Quaternion.Euler(0,-90,0);
                rotacion = 90;
            }
        }

        if (movementDirection.z < 0)
        {
            if (rotacion%360 != 270)
            {   
                transform.localRotation = Quaternion.Euler(0,90,0);
                rotacion = 270;
            }
        }

        enem_rigid.MovePosition(transform.position + (movementDirection * Time.deltaTime * characterVelocity));
     
        //move enemy: 
        /* = new Vector3(transform.position.x + (movementPerSecond.x * Time.deltaTime), 0, 
        transform.position.z + (movementPerSecond.z * Time.deltaTime));*/
 
    }
}
