using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllEndText : MonoBehaviour
{
    public GameObject EndText;
    // Start is called before the first frame update
    void Start()
    {
        EndText.SetActive(false);
        
    }

    void Update()
    {
        if (CountDownTimer.gameTimerInt == 0)
        {
            EndText.SetActive(true);
        }
        
    }
}
