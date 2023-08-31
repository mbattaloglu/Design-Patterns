using UnityEngine;

namespace DesignPatterns.Observer
{
    public class PlayerScore : MonoBehaviour
    {
        public static PlayerScore Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public int score;
        public int highScore;

        private void Start()
        {
            score = 0;
            GetHighScore();
        }

        public void AddScore(int amount)
        {
            score += amount;
        }

        private void GetHighScore()
        {
            highScore = PlayerPrefs.GetInt("HighScore", 0);
        }

        public void SetHighScore()
        {
            if (score > highScore)
            {
                Debug.Log("New High Score Saved.");
                PlayerPrefs.SetInt("HighScore", score);
                highScore = score;
            }
        }

        public void ResetHighScore()
        {
            Debug.Log("High Score Reset.");
            PlayerPrefs.SetInt("HighScore", 0);
            highScore = 0;
        }
    }
}
