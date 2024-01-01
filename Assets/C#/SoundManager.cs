using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public AudioSource audioSource;
    [SerializeField] public AudioClip PlayerJump;
    // Start is called before the first frame update
    
    void Start()
    {
        UnityEngine.AudioClip PlayerJump = audioSource.clip;
    }
    public void PlayPllayerJump() {
        audioSource.PlayOneShot(PlayerJump);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
