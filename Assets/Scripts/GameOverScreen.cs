using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text text;
    public HealthManager HealthManager;
    // Update is called once per frame


    void Update()
    {
        if (HealthManager.gameover)
        {
            text.text = "Game over\n press any key to start again";
        }
        else
        {
            text.text = "";
        }
    }
}
