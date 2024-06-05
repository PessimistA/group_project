/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");
        }
        if (collision.CompareTag("Player"))
        {
            // Oyuncuya kazandığını belirten mesajı gösterme
            winMessage.gameObject.SetActive(true);
            winMessage.text = "Tebrikler! Oyunu kazandınız!";
        }
    }
}*/
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPoint : MonoBehaviour
{
    public Text winMessage; // UI Text nesnesi

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Kazandınız mesajını gösterme
            winMessage.gameObject.SetActive(true);
            winMessage.text = "Tebrikler! Oyunu kazandınız!";
        }
    }
}*/
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishPoint : MonoBehaviour
{
    public Text winMessage; // UI Text nesnesi

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Kazandınız mesajını gösterme
            if (winMessage != null)
            {
                winMessage.gameObject.SetActive(true);
                winMessage.text = "Tebrikler! Oyunu kazandınız!";
            }
            else
            {
                Debug.LogWarning("WinMessage nesnesi atanmamış!");
            }

            // Oyuncunun hareketini durdur
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
    }
}
*/
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishPoint : MonoBehaviour
{
    public TextMeshProUGUI winMessage; // TextMeshPro UI Text nesnesi

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Kazandınız mesajını gösterme
            if (winMessage != null)
            {
                winMessage.gameObject.SetActive(true);
                winMessage.text = "Tebrikler! Oyunu kazandınız!";
            }
            else
            {
                Debug.LogWarning("WinMessage nesnesi atanmamış!");
            }

            // Oyuncunun hareketini durdurma
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
    }
}*/




/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishPoint : MonoBehaviour
{
    public Timer timerScript; // Timer scriptine referans

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Oyuncunun hareketini durdurma
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            // Oyuncunun hareket scriptine ulasildigini bildirme
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.ReachFinishPoint();
            }

            // Timer'i durdurma
            if (timerScript != null)
            {
                timerScript.StopTimer();
            }
            else
            {
                Debug.LogWarning("Timer scripti atanmamis!");
            }
        }
    }
}*/
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Karakterin bitiş noktasına ulaşıp ulaşmadığını kontrol eder
        if (other.CompareTag("Player"))
        {
            // Karakterin hareketini durdurur
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.StopMovement();
                Debug.Log("Bitiş noktasına ulaşıldı!");
            }
        }
    }
}*/

/*KRONOMETRE DURDURULMADAN ONCE
 * 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishPoint : MonoBehaviour
{
    //public TextMeshProUGUI winMessage; // TextMeshPro UI Text nesnesi

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Kazandınız mesajını gösterme


            // Oyuncunun hareketini durdurma
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            // Oyuncunun hareket scriptine ulaşıldığını bildirme
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.ReachFinishPoint();
            }
        }
    }
} mohemtarin */

/* Akharin
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Oyuncunun hareketini durdurma
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            // Oyuncunun hareket scriptine ulaşıldığını bildirme
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.ReachFinishPoint();
            }

            // Timer'i durdur
            GameObject timerObject = GameObject.Find("TimerObject");
            if (timerObject != null)
            {
                Timer timer = timerObject.GetComponent<Timer>();
                if (timer != null)
                {
                    timer.StopTimer();
                    Debug.Log("Kronometre durduruldu.");
                }
                else
                {
                    Debug.LogError("Timer script is missing from the TimerObject.");
                }
            }
            else
            {
                Debug.LogError("TimerObject is not found.");
            }
        }
    }
}*/


/* akhare akhar
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public Timer timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Oyuncunun hareketini durdurma
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;

            // Oyuncunun hareket scriptine ulaşıldığını bildirme
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.ReachFinishPoint();
            }

            // Timer'i durdur
            if (timer != null)
            {
                timer.StopTimer();
                Debug.Log("Kronometre durduruldu.");
            }
            else
            {
                Debug.LogError("Timer referansı eksik.");
            }
        }
    }
}*/

/* Lasttttt
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public Timer timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");

            // Oyuncunun hareketini durdurma
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
                rb.velocity = Vector2.zero;

            // Oyuncunun hareket scriptine ulaşıldığını bildirme
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.ReachFinishPoint();
            }

            // Timer'i durdur
            if (timer != null)
            {
                timer.StopTimer();
                Debug.Log("Kronometre durduruldu.");
            }
            else
            {
                Debug.LogError("Timer referansı eksik.");
            }
        }
    }
}*/


/* lasttttttttttttt
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public Timer timer; // Reference to the Timer script

    private void OnTriggerEnter2D(Collider2D collision)
    {
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
            }

            // Stop the timer
            if (timer != null)
            {
                timer.StopTimer();
                Debug.Log("Timer stopped.");
            }
            else
            {
                Debug.LogError("Timer reference is missing.");
            }
        }
    }
}*/

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






