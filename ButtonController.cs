using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    //info

    public GameObject square;
    public GameObject passSquare;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void NextTurkey()
    {
        SceneManager.LoadScene(2);
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void LevelMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void whenButtonClicked()
    {
        if (square.activeInHierarchy == true)
            square.SetActive(false);
        else
            square.SetActive(true);
    }
    public void whenButtonClicked2()
    {
        if (passSquare.activeInHierarchy == true)
            passSquare.SetActive(false);
        else
            passSquare.SetActive(true);
    }

    public void NextGerman()
    {
        SceneManager.LoadScene (3);
    }



}
