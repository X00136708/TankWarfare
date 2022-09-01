using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int CurrentHealth;
    //this is the max amount of health the person will have
    public int MaxHealth = 100;
    //reference to the health bar script
    public Health_Bar healthBar;
    // Start is called before the first frame update
    void Start()
    {//gives the player max health and shows on the health bar
        CurrentHealth = MaxHealth;
        healthBar.setMaxHealth(MaxHealth);
    }
    
}
