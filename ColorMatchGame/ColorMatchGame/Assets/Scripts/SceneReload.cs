using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneReload : MonoBehaviour
{
 public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
