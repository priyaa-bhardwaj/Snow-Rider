using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crash : MonoBehaviour
{
    [SerializeField] float DelayStart=1f;
    [SerializeField] ParticleSystem CrashParticles;
    bool hasCrashed;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Ground" && !hasCrashed) 
        {
            hasCrashed=true;
            FindObjectOfType<PlayerControl>().DisableControl();
            CrashParticles.Play();
            Invoke("ReloadScene", DelayStart);
            GetComponent<AudioSource>().Play();
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
