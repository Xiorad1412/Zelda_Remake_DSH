using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mazmorra : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Dungeon", LoadSceneMode.Single);
        }
    }


}
