using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    [SerializeField] private GameObject winMenu;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    private int score = 0;
    private int highScore = 0;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void Start()
    {
        UpdateDisplay();
    }

    public void IncrementScore()
    {
        score++;
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }

        if (score >= 30)
        {
            ShowWinText();
        }

        UpdateDisplay();
    }

    void ShowWinText()
    {
        if (winMenu != null)
            winMenu.SetActive(true);
            Time.timeScale = 0;
    }

    public void ResetScore()
    {
        score = 0;
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        if (scoreText != null) scoreText.text = "Score: " + score;
        if (highScoreText != null) highScoreText.text = "High Score: " + highScore;
    }
}
