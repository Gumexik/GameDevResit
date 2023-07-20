using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUi : MonoBehaviour
{

    public GameObject gameOverUI;
    public GameObject player;
    public GameObject gameMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (!player) {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            Destroy(gameMenuUI);
        }
        else {
            gameOverUI.SetActive(false);
        }
    }

    public void LoadMenu() {
    SceneManager.LoadScene("MainMenu");
 }

    public void QuitGame() {
        Application.Quit();
    }
}
