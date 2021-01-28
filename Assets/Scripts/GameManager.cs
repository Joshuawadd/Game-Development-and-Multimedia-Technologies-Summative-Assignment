using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool GameIsOver;

    public GameObject gameoverUI;

    public GameObject completeLevelUI;

    public SceneFader sceneFader;

    void Start()
    {
        GameIsOver = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
        {
            return;
        }

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;
        gameoverUI.SetActive(true);
    }

    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
