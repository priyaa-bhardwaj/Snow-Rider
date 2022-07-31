using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float DelayStart=1f;
    [SerializeField] ParticleSystem FinishParticles;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Player")
        {
            FinishParticles.Play();
            Invoke("ReloadScene", DelayStart);
            GetComponent<AudioSource>().Play();
        }
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
        SceneManager.LoadScene(1);

    }
}
