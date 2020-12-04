using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _MainMenu : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject village;
    public GameObject page1;
    public void PlayeButton()
    {
        SceneManager.LoadScene(1);
    }

    public void Page1()
    {
        mainMenuCanvas.SetActive(false);
        page1.SetActive(true);
        village.SetActive(false);
    }

    public void BackToMenu()
    {
        mainMenuCanvas.SetActive(true);
        page1.SetActive(false);
        village.SetActive(true);
    }
}
