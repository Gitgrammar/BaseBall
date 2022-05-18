using System.Collections;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float z = 2000;//force strenth

        Rigidbody rd = GetComponent < Rigidbody>();

        rd.AddForce(0, 0, -z);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
