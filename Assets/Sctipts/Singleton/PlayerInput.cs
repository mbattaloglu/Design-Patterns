using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class PlayerInput : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key pressed");
                PlayerScore.Instance.AddScore(1);
            }
        }
    }
}
