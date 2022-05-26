using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBat : MonoBehaviour
{
    private AudioSource audioSourceBat;
    public AudioClip seBat;

    // Start is called before the first frame update
    void Start()
    {
        audioSourceBat = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            audioSourceBat.PlayOneShot(seBat);
        }
    }
}
