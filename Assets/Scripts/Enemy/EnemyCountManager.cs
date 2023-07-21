using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;

public class EnemyCountManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI enemiesLeftText;
    List<Enemy> enemies = new List<Enemy>();
    public GameObject levelFinished;

    void Update()
    {
        enemies = GameObject.FindObjectsOfType<Enemy>().ToList();
        UpdateEnemiesLeftText();
        LevelFinished();
    }

    // Update is called once per frame
    void UpdateEnemiesLeftText()
    {
        enemiesLeftText.text = $"Enemies Left: {enemies.Count}";
    }

    private void LevelFinished() {
        if (levelFinished == null) return;
        if (enemies.Count == 0) {
            levelFinished.SetActive(true);
        }
        
    }

    public void ProceedToNextLevel() {
        SceneManager.LoadScene("LevelTwo");
    }

    public void BackToMainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
