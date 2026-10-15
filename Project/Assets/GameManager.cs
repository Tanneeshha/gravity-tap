using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Transform plank;
    public float maxTilt = 30f;
    public GameObject restartButton;
    public TextMeshProUGUI scoreText;

    private int score = 0;
    private bool gameOver = false;

    void Update()
    {
        if (gameOver) return;

        float z = plank.rotation.eulerAngles.z;

        if ((z > maxTilt && z < 180) || (z < 360 - maxTilt && z > 180))
        {
            Debug.Log("Game Over!");
            Time.timeScale = 0;
            gameOver = true;
            restartButton.SetActive(true);
        }
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
