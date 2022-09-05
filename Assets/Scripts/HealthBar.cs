using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public int health;
    public void setMaxHealth(int health)
    {//sets players health bar to max
        slider.maxValue = health;
        slider.value = health;
        this.health = health;
    }
    public int setHealth(int health)
    {
        slider.value = health;
        this.health = health;
        return health;
    }
}
