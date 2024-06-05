
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController1 : MonoBehaviour
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
        if (collision.gameObject.CompareTag("barrier"))
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
}

















