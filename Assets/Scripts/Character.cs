using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] public int currentHealth, maxHealth = 5,
     experience, maxExperience = 1000, currentLevel = 1 ;

     private void OnEnable() {
        // subscribing to event
        ExperienceManager.Instance.OnExperienceChange += HandleExperienceChange;
     }

     private void OnDisable() {
        // unsubscribing from event
        ExperienceManager.Instance.OnExperienceChange -= HandleExperienceChange;
     }

  

    void Start() {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount){
        currentHealth -= amount;

        if(currentHealth <= 0 ){
            Destroy(gameObject);
        }
    }

    private void HandleExperienceChange(int newExperience) {
        experience += newExperience;
        if(experience >= maxExperience) {
            LevelUp();
        }
    }

    private void LevelUp() {
        maxHealth += 1;
        currentHealth = maxHealth;
        currentLevel ++;
        

        experience = 0;
        maxExperience += 100;
    }
    
    public int getPlayerLevel() {
        return currentLevel;
    }
}
