using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI")]
    public TMP_Text killsText;
    public GameObject winPanel;
    public GameObject gameOverPanel;

    [Header("Settings")]
    public int killsToWin = 5;

    private int currentKills = 0;

    private void Awake()
    {
        Instance = this;

        winPanel.SetActive(false);
        gameOverPanel.SetActive(false);

        UpdateKillsUI();
    }

    public void AddKill()
    {
        currentKills++;

        UpdateKillsUI();

        if (currentKills >= killsToWin)
        {
            WinGame();
        }
    }

    private void UpdateKillsUI()
    {
        killsText.text = "Kills: " + currentKills + "/" + killsToWin;
    }

    public void WinGame()
    {
        winPanel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
    }
}