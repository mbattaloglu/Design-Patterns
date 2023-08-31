using UnityEngine;

namespace DesignPatterns.Observer
{
    public class PlayerInput : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerScore.Instance.AddScore(1);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                PlayerScore.Instance.SetHighScore();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                PlayerScore.Instance.ResetHighScore();
            }
            
        }
    }
}
