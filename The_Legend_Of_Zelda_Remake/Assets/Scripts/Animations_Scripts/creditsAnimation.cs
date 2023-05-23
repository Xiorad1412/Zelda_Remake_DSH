using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditsAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ReturnToMainMenu", 18.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene("PantallaDeTitulo");
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("PantallaDeTitulo");
    }
}
