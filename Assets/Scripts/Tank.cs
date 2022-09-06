using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tank : MonoBehaviour
{
    public Bullet bullet { get; set; }
    public GameObject healthBarObj;
    public HealthBar healthBar;
    public int maxHealth { get; set; }
    private int currentHealth;
    public void Start()
    {
       //healthBar = healthBarObj.GetComponent<HealthBar>();
    }
    public int CurrentHealth
    {
        get
        {
            return currentHealth;
        }
        set
        {
            if (healthBar != null)
            {
                currentHealth = healthBar.setHealth(value);
            }
        }
    }
    public abstract void Move();
    public abstract void Shoot();
    public void TakeDamage(GameObject obj, int damage)
    {
        if (!(maxHealth <= 0))
        {
            if(CurrentHealth != null)
                CurrentHealth -= damage;
        }
        else
        {
            Die();
        }
    }
    public abstract void Die();

}
