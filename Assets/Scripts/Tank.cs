using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tank : MonoBehaviour
{
    public Bullet bullet { get; set; }
    public GameObject healthBarObj;
    public HealthBar healthBar;
    public int maxHealth { get; set; }
    public bool botsTurn;
    private int currentHealth;
            
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
        if (!(maxHealth < 0))
        {            
                CurrentHealth -= damage;
        }
        else
        {
            Die();
        }
    }
    public abstract void Die();
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("Bullet"))
        {
            if (collision.otherCollider.tag.Equals("PlayerTank"))
            {
                botsTurn = false;
            }
            else if (collision.otherCollider.tag.Equals("BotTank"))
            {
                botsTurn = true;
            }
            TakeDamage(this.gameObject, bullet.damage);
        }
    }
}
