using UnityEngine;

public class StepSound : MonoBehaviour
{
    public AudioClip footstepSound;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void PlayFootstepSound()
    {
        audioSource.PlayOneShot(footstepSound);
    }
}