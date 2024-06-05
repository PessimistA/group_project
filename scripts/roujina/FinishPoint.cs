using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    public Timer timer; // Reference to the Timer script

    string currentSceneName;
    void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("çarpışma gerçekleştirildi!");
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Stop player movement
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
                rb.velocity = Vector2.zero;

            // Notify player movement script
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.ReachFinishPoint();
                if (currentSceneName== "Level1")
                {
                    SceneManager.LoadSceneAsync("1stwinscene");
                }
                if (currentSceneName == "Level3")
                {
                    SceneManager.LoadSceneAsync("3stwinscene 2");
                }
                if (currentSceneName == "Level5")
                {
                    SceneManager.LoadSceneAsync("5stwinscene 4");
                }
                if (currentSceneName == "Level2")
                {
                    SceneManager.LoadSceneAsync("2stwinscene 1");
                }
                if (currentSceneName == "level4")
                {
                    SceneManager.LoadSceneAsync("4stwinscene 3");
                }
                if (currentSceneName == "level6")
                {
                    SceneManager.LoadSceneAsync("6stwinscene 5");
                }
            }
            // Stop the timer
            if (timer != null)
            {
                float finalTime = timer.StopTimer();
                Debug.Log("Timer stopped at " + finalTime);
            }
            else
            {
                Debug.LogError("Timer reference is missing.");
            }
        }
    }
}






