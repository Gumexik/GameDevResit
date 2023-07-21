using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{

    public int health;
    public int maxHealth;
    public Sprite emptyHeart;
    public Sprite fullHeart;
    public Image[] life;

    public Character playerHealth;
    

    void Update()
    {
        health = playerHealth.currentHealth;
        maxHealth = playerHealth.maxHealth;

        for (int i = 0; i < life.Length; i++) {
            if(i < health) {
                life[i].sprite = fullHeart;
            } else {
                life[i].sprite = emptyHeart;
            }
            if (i < maxHealth) {
                life[i].enabled = true;
        }
        else {
            life[i].enabled = false;
        }
    }
}
}
