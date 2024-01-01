using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class HealthSystem : MonoBehaviour
{

    private float healthPoints;
    private float maxHealth;
    private float healthsystem;
    // Start is called before the first frame update

    public HealthSystem(int maxHealth) {
        this.maxHealth = maxHealth;
        healthPoints = maxHealth;
    }
    public float gethealth() { return healthPoints; }
    public float gethealthpercentage() { return healthPoints / maxHealth; }

    public void Damage(int damageAmont) {
        healthPoints -= damageAmont;
        if (healthPoints <= 0) { healthPoints = 0; }
    }
    public void heal(int healAmont) {
        healthPoints += healAmont;
        if (healthPoints > maxHealth) { healthPoints = maxHealth; }
    }
    
    
}
