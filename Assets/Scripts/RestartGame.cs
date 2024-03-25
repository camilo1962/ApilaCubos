using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void Salir()
    {
        Application.Quit();
    }
    public void Borra()
    {
        PlayerPrefs.DeleteAll();
    }
}
