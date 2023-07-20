using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public static event Action<Enemy> OnEnemyKilled;
    [SerializeField] float health, maxHealth = 10;

    [SerializeField] FloatingHealthBar healthBar;
    
    [SerializeField] int expAmount = 100;

    void Awake() {
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }


    void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    public void TakeDamage(int damageAmount) {

        health -= damageAmount;
        healthBar.UpdateHealthBar(health, maxHealth);

        if (health <=0) {
            Destroy(gameObject);
            OnEnemyKilled?.Invoke(this);
            ExperienceManager.Instance.AddExperience(expAmount);
        }
    }
}
