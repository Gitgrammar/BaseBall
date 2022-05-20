using System.Collections;
using UnityEngine;

public class DeleteBall : MonoBehaviour
{
    private Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground" & collision.gameObject.tag != "Bat" & collision.gameObject.tag != "Stadium")
        {
            rd.velocity = Vector3.zero;
            transform.position = new Vector3(0, 1.2f, -5.8f);
            ShootBall.shootSwitch = true;
        }
        }
    }
    
        
    

