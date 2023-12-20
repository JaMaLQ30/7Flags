using UnityEngine;

public class CircleController : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public AudioClip musicClip;
    private AudioSource audioSource;
    private bool isPlaying = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isPlaying)
            {
                audioSource.clip = musicClip;
                audioSource.Play();
                isPlaying = true;
            }
            else
            {
                audioSource.Stop();
                isPlaying = false;
            }
        }

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}