using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public GameObject[] objectsToDisable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameFinished();
        }
    }

    public void GameFinished()
    {
        // Get updated score
        int score = FindObjectOfType<PengaturGame>().CalculateScore();

        // Check if the score is at least 200
        if (score >= 200)
        {
            // Show game over screen
            gameOverScreen.Setup(score);

            // Disable objects after showing game over screen (if needed)
            DisableObjects();
        }
    }

    private void DisableObjects()
    {
        foreach (GameObject obj in objectsToDisable)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}
