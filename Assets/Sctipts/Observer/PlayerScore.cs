using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class PlayerScore : MonoBehaviour, ISubject
    {
        public List<IObserver> observers = new List<IObserver>();

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
            observers.Add(ScorePresenter.Instance);
            score = 0;
            GetHighScore();
            Notify();
        }

        public void AddScore(int amount)
        {
            score += amount;
            Notify();
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
            Notify();
        }

        public void ResetHighScore()
        {
            Debug.Log("High Score Reset.");
            PlayerPrefs.SetInt("HighScore", 0);
            highScore = 0;
            Notify();
        }

        public void AttachObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void DettachObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in observers)
            {
                observer.OnNotify();
            }
        }
    }
}
