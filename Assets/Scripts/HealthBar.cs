using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public void setMaxHealth(int health)
    {//sets players health bar to max
        slider.maxValue = health;
        slider.value = health;
    }
    public void setHealth(int health)
    {//this sets the player health to 100 every restart
        slider.value = health;
    }
}
