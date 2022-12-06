using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject gameButtons;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        gameButtons.SetActive(true);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        gameButtons.SetActive(false);
        Time.timeScale = 0;
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
