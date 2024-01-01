using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Slider slider;
    HealthSystem healthSystem = new HealthSystem(100);

    public void Update()
    {
        slider.value = healthSystem.gethealthpercentage();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            healthSystem.Damage(10);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heal")
        {
            healthSystem.heal(10);
        }
    }
}