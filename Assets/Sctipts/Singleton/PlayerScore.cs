using UnityEngine;

namespace DesignPatterns.Singleton
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
        private int score = 0;

        public void AddScore(int amount)
        {
            score += amount;
            Debug.Log("Score: " + score);
        }
    }
}
