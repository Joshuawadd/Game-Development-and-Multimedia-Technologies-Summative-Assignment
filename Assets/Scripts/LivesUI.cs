using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{

    public Text livesText;

    private string livesGrammar;

    // Update is called once per frame
    void Update()
    {

        if (PlayerStats.Lives == 1)
        {
            livesGrammar = " LIFE";
        } else
        {
            livesGrammar = " LIVES";
        }

        livesText.text = PlayerStats.Lives.ToString() + livesGrammar;
    }
}
