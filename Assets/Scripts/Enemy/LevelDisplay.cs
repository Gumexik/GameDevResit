using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelDisplay : MonoBehaviour
{
    public Character character;
    [SerializeField] TextMeshProUGUI levelText;

    void Update() {
        UpdateLevel();
    }

        void UpdateLevel()
    {
        levelText.text = $"Level: {character.getPlayerLevel()}";
    }
}
