using System.Collections;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    // Start is called before the first frame update
    
        private float timer = 0.0f;//force strenth
        private float timeLimit = 1.0f;
        public static bool shootSwitch;

    void Start()
    {
        shootSwitch = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (shootSwitch)
        {
            timer += Time.deltaTime;
        }
        if ((timer > timeLimit) & shootSwitch)
        {
            float z = 2200;
        Rigidbody rd = GetComponent<Rigidbody>();

        rd.AddForce(0, 0, -z);
            timer = 0.0f;
            shootSwitch = false;

        }
        if (CountDownTimer.gameTimerInt == 0)
        {
            shootSwitch = false;
        }
    }
}
