using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene(string Name)
    {
        SceneManager.LoadScene(Name);
    }
    public void Leveltwo()
    {
        SceneManager.LoadScene(sceneName: "Leve9");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(sceneName: "Main Menu");
    }
    public void VR_Mode()
    {
        SceneManager.LoadScene(sceneName: "VR_Mode");
    }
}
