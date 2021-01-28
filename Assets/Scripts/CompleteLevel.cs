using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public SceneFader sceneFader;

    public string menuSceneName = "MainMenu";

    public string nextLevel =  "Level02";
    public int levelToUnlock = 2;

    void OnEnable ()
    {
        if (levelToUnlock > PlayerPrefs.GetInt("levelReached", 1))
        {
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }
    }

    public void Continue ()
    {
        sceneFader.FadeTo(nextLevel);
    }

    public void Menu ()
    {
        sceneFader.FadeTo(menuSceneName);
    }
}
