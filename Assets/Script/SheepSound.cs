using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSound : MonoBehaviour
{
    public AudioClip soundClip;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.clip = soundClip;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.Stop();
        }
    }
}
