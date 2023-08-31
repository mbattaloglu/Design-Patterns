using UnityEngine;
namespace DesignPatterns.Singleton
{
    public class PlayerInput : MonoBehaviour
    {
        private PlayerScore playerScore;

        private void Start()
        {
            playerScore = FindObjectOfType<PlayerScore>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key pressed");
                playerScore.AddScore(1);
            }
        }
    }
}
