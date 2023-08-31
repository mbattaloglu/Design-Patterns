using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Singleton
{

    public class PlayerScore : MonoBehaviour
    {
        private int score = 0;

        public void AddScore(int amount)
        {
            score += amount;
            Debug.Log("Score: " + score);
        }
    }
}
