using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Libreria para el control de las escenas
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Metodo para ir a la "SampleScene"
    public void ChangeScene(string name) 
    {
        SceneManager.LoadScene(name);
    }

    // Metodo para cerrar la aplicación
    public void CloseScene() 
    {
        Application.Quit();
        print("Me voy a cerrar");
    }

}
