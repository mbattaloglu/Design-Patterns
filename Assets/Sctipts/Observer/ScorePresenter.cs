using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.Observer
{
    public class ScorePresenter : MonoBehaviour
    {
        public static ScorePresenter Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Instance = null;
            }
        }

        public Text scoreText;
        public Text highScoreText;

        private void Update()
        {
            scoreText.text = "Score: " + PlayerScore.Instance.score.ToString();
            highScoreText.text = "High Score: " + PlayerScore.Instance.highScore.ToString();
        }
    }
}
