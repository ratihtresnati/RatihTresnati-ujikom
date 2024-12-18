using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int intScene;

    public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
