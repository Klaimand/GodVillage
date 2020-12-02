using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _MainMenu : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject quitConfirmationCanvas;
    public void PlayeButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ConfirmationQuitting()
    {
        mainMenuCanvas.SetActive(false);
        quitConfirmationCanvas.SetActive(true);
    }

    public void BackToMenu()
    {
        mainMenuCanvas.SetActive(true);
        quitConfirmationCanvas.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
        print("Quit");
    }
}
