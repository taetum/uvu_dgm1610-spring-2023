using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource buttonSound;
    public AudioClip buttonClick;

    public int sceneToLoad;

    private void Start()
    {
        buttonSound = GetComponent<AudioSource>();
    }
    public void StartGame()
    {
        buttonSound.PlayOneShot(buttonClick, 1.0f);
        SceneManager.LoadScene(sceneToLoad); // scene to load
        Debug.Log("New scene loaded!");

    }

    public void QuitScene()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
        buttonSound.PlayOneShot(buttonClick, 1.0f);
    }
}