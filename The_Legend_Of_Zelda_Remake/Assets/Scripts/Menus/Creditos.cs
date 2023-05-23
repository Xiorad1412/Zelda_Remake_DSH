using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
        }
    }
}
