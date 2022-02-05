using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//ABSTRACTION
public class ButtonManager : MonoBehaviour
{
    [SerializeField] private string mainMenu;
    [SerializeField] private string scene;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        //Return to Main Menu
        SceneManager.LoadScene(mainMenu);
    }

    public void Scene()
    {
        //Return to Main Menu
        SceneManager.LoadScene(scene);
    }
}
