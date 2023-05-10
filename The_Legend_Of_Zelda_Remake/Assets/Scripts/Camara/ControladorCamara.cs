using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public Transform player;
    public float smoothspeed;

    private Vector3 targetPos, newPos;

    public Vector3 minPos, maxPos;


    void LateUpdate() 
    {
       if (transform.position != player.position)
       {
            targetPos = player.position;

            Vector3 Limites = new Vector3 
            (
                Mathf.Clamp(targetPos.x, minPos.x, maxPos.x),
                Mathf.Clamp(targetPos.y, minPos.y, maxPos.y),
                Mathf.Clamp(targetPos.z, minPos.z, maxPos.z)
            );

            newPos = Vector3.Lerp(transform.position, Limites, smoothspeed);
            transform.position = newPos;
            
       } 
    }
}
