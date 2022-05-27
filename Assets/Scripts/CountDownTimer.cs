using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    private int gameTimerInt;
    private float gameTimerFloat;
    public Text timeText;

    void Start()
    {
        gameTimerFloat = 60.0f;
        gameTimerInt = (int)gameTimerFloat;
        timeText.text = "" + gameTimerInt.ToString();
        
    }

    void Update()
    {
        if (gameTimerFloat>0.0f){
            gameTimerFloat -= Time.deltaTime;
            gameTimerInt = (int)gameTimerFloat;
            timeText.text = "" + gameTimerInt.ToString();

        }
        if (gameTimerFloat <= 0.0f)
        {
            gameTimerInt = 0;
            timeText.text = "" + gameTimerInt.ToString();
        }
        
    }
}
