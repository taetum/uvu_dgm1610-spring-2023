using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public int sceneToLoad;
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); // scene to load
        Debug.Log("New scene loaded!");
    }

public void QuitScene()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
