using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "LevelSelector";

    public SceneFader sceneFader;

    public GameObject howToPlayUI;

    public void Play()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void Controls()
    {
        howToPlayUI.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Exiting...");
        Application.Quit();
    }

    public void Continue()
    {
        howToPlayUI.SetActive(false);
    }
}
