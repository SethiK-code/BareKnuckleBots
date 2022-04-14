using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public bool hit;

    public void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        
        currentHealth -= amount;
        if (currentHealth <= 0f)
        {
            Die();
        }
        Debug.Log(amount);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
