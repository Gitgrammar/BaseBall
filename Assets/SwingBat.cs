using System.Collections;
using UnityEngine;

public class SwingBat : MonoBehaviour
{
    float r = 30;//rotation Speed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            transform.Rotate(0, -r, 0);
        
    }
}
