

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamehandler : MonoBehaviour
{
    public Load load;
    public float healtp = 100;
    public Slider slider;
    HealthSystem healthsystem = new HealthSystem(100);
    Save binary = new Save();

    public void save() {
       binary.saveToFile(healthsystem);
    }
    public void FixedUpdate()
    {
        slider.value = healthsystem.gethealthpercentage();

    }
    public void Loadiong() { 
    healthsystem = load.gethealth();
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        { healthsystem.Damage(10); }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heal")
        { healthsystem.heal(10); }
    }
}