using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{


    public void Jugar(){

        SceneManager.LoadScene("Overworld");
    }

    public void Salir(){
        Debug.Log("Saliendo de la aplicacion...");
        Application.Quit();
    }

}
