using System.Collections;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    // Start is called before the first frame update
    
        float timer = 0.0f;//force strenth
        float timeLimit = 1.0f;
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
            float z = 2000;
        Rigidbody rd = GetComponent<Rigidbody>();

        rd.AddForce(0, 0, -z);
            timer = 0.0f;
            shootSwitch = false;

        }
    }
}
