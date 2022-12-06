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
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        gameButtons.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        gameButtons.SetActive(false);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneController.Instance.Menu();
    }
}
