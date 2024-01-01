using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider timerSlider;
    public TextMeshProUGUI timerText;
    public float gametime;

    private bool stopTimer;
    void Start()
    {
        stopTimer = false;
        timerSlider.maxValue = gametime;
        timerSlider.value = gametime;
    }


    void Update()
    {
        float time = gametime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
        if (time <= 0)
        {
            stopTimer = false;
        }
        if (stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = time;
        }
    }
}