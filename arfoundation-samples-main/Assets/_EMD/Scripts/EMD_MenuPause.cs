using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class EMD_MenuPause : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    public AudioMixer son;
    public void PauseButton()
    {
        pauseMenuCanvas.SetActive(true);
    }
    public void ContinueButton()
    {
        pauseMenuCanvas.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
        print("Quit");
    }
    public void SonOffButton()
    {
        son.SetFloat("MainVolume", 0);
    }
    public void SonOnButton()
    {
        son.SetFloat("MainVolume", 80);
    }
}
