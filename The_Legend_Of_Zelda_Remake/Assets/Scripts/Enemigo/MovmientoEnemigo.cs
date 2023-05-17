using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmientoEnemigo : MonoBehaviour
{

    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 1f;
    private float characterVelocity = 1.5f;
    private Vector3 movementDirection;
    private Vector3 movementPerSecond;
 

    //private Random r = Random();

    //private int Aleatorio;
 
    void Start()
    {
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
    }



    void calcuateNewMovementVector()
    {
        //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
        if (Time.time % 2 == 0)
        movementDirection = new Vector3(Random.Range(-1.0f, 1.0f), 0, 0).normalized;

        else
        movementDirection = new Vector3(0, 0, Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }
 
    void Update()
    {
        //if the changeTime was reached, calculate a new movement vector
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }
     
        //move enemy: 
        transform.position = new Vector3(transform.position.x + (movementPerSecond.x * Time.deltaTime), 0, 
        transform.position.z + (movementPerSecond.z * Time.deltaTime));
 
    }
}
