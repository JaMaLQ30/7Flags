using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    public void playButton()
    {
        audio.Play();
    }
}
