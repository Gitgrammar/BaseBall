using System.Collections;
using UnityEngine;

public class WallEffect : MonoBehaviour
{
    private ParticleSystem particle;
    public int i;
    void Start()
    {
        particle = this.GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        particle.Play();
    }
}
