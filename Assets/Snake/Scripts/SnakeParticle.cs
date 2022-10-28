using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeParticle : MonoBehaviour
{
    public ParticleSystem Particle;

    void PlaySound()
    {

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        Particle.Play();
        PlaySound();
        Destroy(this.gameObject, 0.25f);        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
