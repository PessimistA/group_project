/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the move speed as needed

    void Update()
    {
        // Get input from arrow keys or WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction based on input
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

        // Move the player using the calculated movement direction
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with a barrier
        if (collision.gameObject.CompareTag("Barrier"))
        {
            // If colliding with a barrier, stop the movement by setting the velocity to zero
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
    }
}*/


/* Timer durmadan once 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hızını ayarlayın
    private bool hasReachedFinish = false; // FinishPoint'a ulaşıldı mı?

    void Update()
    {
        if (!hasReachedFinish)
        {
            // Klavyeden giriş al
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Girişlere göre hareket yönünü hesapla
            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

            // Hesaplanan hareket yönü ile oyuncuyu hareket ettir
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Bariyer ile çarpışma kontrolü
        if (collision.gameObject.CompareTag("Barrier"))
        {
            // Bariyer ile çarpışma durumunda hareketi durdur
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
    }

    // FinishPoint'a ulaşıldığında çağrılacak metod
    public void ReachFinishPoint()
    {
        hasReachedFinish = true;
    }
}*/

/* mohemtarin
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hızını ayarlayın
    private bool hasReachedFinish = false; // FinishPoint'a ulaşıldı mı?

    void Update()
    {
        if (!hasReachedFinish)
        {
            // Klavyeden giriş al
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Girişlere göre hareket yönünü hesapla
            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

            // Hesaplanan hareket yönü ile oyuncuyu hareket ettir
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Bariyer ile çarpışma kontrolü
        if (collision.gameObject.CompareTag("Barrier"))
        {
            // Bariyer ile çarpışma durumunda hareketi durdur
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
    }

    // FinishPoint'a ulaşıldığında çağrılacak metod
    public void ReachFinishPoint()
    {
        hasReachedFinish = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            ReachFinishPoint(); // Karakter hareketini durdur

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


/* Akharin
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hızını ayarlayın
    private bool hasReachedFinish = false; // FinishPoint'a ulaşıldı mı?

    void Update()
    {
        if (!hasReachedFinish)
        {
            // Klavyeden giriş al
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Girişlere göre hareket yönünü hesapla
            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

            // Hesaplanan hareket yönü ile oyuncuyu hareket ettir
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Bariyer ile çarpışma kontrolü
        if (collision.gameObject.CompareTag("Barrier"))
        {
            // Bariyer ile çarpışma durumunda hareketi durdur
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
    }

    // FinishPoint'a ulaşıldığında çağrılacak metod
    public void ReachFinishPoint()
    {
        hasReachedFinish = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            ReachFinishPoint(); // Karakter hareketini durdur

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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hizini ayarlayin
    private bool hasReachedFinish = false; // FinishPoint'a ulasildi mi?

    void Update()
    {
        if (!hasReachedFinish)
        {
            // Klavyeden giris al
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            // Girislere gore hareket yonunu hesapla
            Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);

            // Hesaplanan hareket yonu ile oyuncuyu hareket ettir
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Bariyer ile çarpışma kontrolu
        if (collision.gameObject.CompareTag("Barrier"))
        {
            // Bariyer ile carpışma durumunda hareketi durdur
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
    }

    // FinishPoint'a ulasildiginda cagrilacak metod
    public void ReachFinishPoint()
    {
        hasReachedFinish = true;
    }
}












