using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }
    public void Playfire()
    {
        SceneManager.LoadScene("1fireRealm");

    }
    public void Playsand()
    {
        SceneManager.LoadScene("1sandRealm");

    }
    public void Playwater()
    {
        SceneManager.LoadScene("1waterRealm");

    }
    public void Playtutorial()
    {
        SceneManager.LoadScene("0tutorial");

    }
}
