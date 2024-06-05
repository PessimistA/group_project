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












