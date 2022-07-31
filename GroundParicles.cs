using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundParicles : MonoBehaviour
{
    [SerializeField] ParticleSystem groundParticle;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Ground")
        {
            groundParticle.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag=="Ground")
        {
            groundParticle.Stop();
        }
    }
}

