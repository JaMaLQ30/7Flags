using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound1()
    {
        audioSource.clip = sound1;
        audioSource.Play();
    }

    public void PlaySound2()
    {
        audioSource.clip = sound2;
        audioSource.Play();
    }

    public void PlaySound3()
    {
        audioSource.clip = sound3;
        audioSource.Play();
    }
}