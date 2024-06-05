/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;  // Timer'i gostermek icin UI Text
    private float startTime;
    private bool isRunning = false;

    void Start()
    {
        startTime = Time.time;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("00");
            string milliseconds = ((t * 1000) % 1000).ToString("000");

            timerText.text = minutes + ":" + seconds + ":" + milliseconds;
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}
*/
/* asli
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Timer'i gostermek icin TextMeshPro
    private float startTime;
    private bool isRunning = false;

    void Start()
    {
        startTime = Time.time;
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString("00");
            string seconds = (t % 60).ToString("00");
            string milliseconds = ((t * 1000) % 1000).ToString("000");

            timerText.text = minutes + ":" + seconds + ":" + milliseconds;
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}*/
/*
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // TextMeshPro - Text bileseni
    private float startTime;
    private bool running = false;

    void Start()
    {
        startTime = Time.time;
        running = true;
    }

    void Update()
    {
        if (running)
        {
            float t = Time.time - startTime;

            // Dakikalar ve saniyeler hesaplaniyor
            int minutes = (int)t / 60;
            int seconds = (int)t % 60;
            float fraction = t * 1000 % 1000;

            // Saniye ve dakika formati
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void StopTimer()
    {
        running = false;
    }
}*/
/*Akhari
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // TextMeshPro - Text bileseni
    private float startTime;
    private bool running = false;

    void Start()
    {
        startTime = Time.time;
        running = true;
    }

    void Update()
    {
        if (running)
        {
            float t = Time.time - startTime;

            // Dakikalar ve saniyeler hesaplaniyor
            int minutes = (int)t / 60;
            int seconds = (int)t % 60;

            // Saniye ve dakika formati
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void StopTimer()
    {
        running = false;
    }
}*/

/*
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isRunning = true;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (isRunning)
        {
            float t = Time.time - startTime;
            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
        }
    }

    public void StopTimer()
    {
        isRunning = false;
        Debug.Log("Timer durduruldu!");
    }
}*/
/*
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // TextMeshPro - Text bileseni
    private float startTime;
    private bool running = false;

    void Start()
    {
        startTime = Time.time;
        running = true;
    }

    void Update()
    {
        if (running)
        {
            float t = Time.time - startTime;

            // Dakikalar ve saniyeler hesaplaniyor
            int minutes = (int)t / 60;
            int seconds = (int)t % 60;

            // Saniye ve dakika formati
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void StopTimer()
    {
        running = false;
    }
}*/

/* lastttttt
using System.Collections;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // TextMeshPro - Text bileseni
    private float startTime;
    private bool running = false;

    void Start()
    {
        if (timerText == null)
        {
            Debug.LogError("Timer Text referansi ayarlanmamis!");
            return; // Timer Text referansi yoksa kodu devam ettirmeyelim
        }

        startTime = Time.time;
        running = true;
    }

    void Update()
    {
        if (running && timerText != null)
        {
            float t = Time.time - startTime;

            // Dakikalar ve saniyeler hesaplaniyor
            int minutes = (int)t / 60;
            int seconds = (int)t % 60;

            // Saniye ve dakika formati
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void StopTimer()
    {
        running = false;
    }
}*/


/* akharin kod
using System.Collections;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Reference to TextMeshPro - Text component
    private float startTime;
    private bool isRunning = false;

    private void Start()
    {
        if (timerText == null)
        {
            Debug.LogError("Timer Text reference is not set!");
            return;
        }

        startTime = Time.time;
        isRunning = true;
    }

    private void Update()
    {
        if (isRunning && timerText != null)
        {
            float elapsedTime = Time.time - startTime;

            // Calculate minutes and seconds
            int minutes = (int)(elapsedTime / 60);
            int seconds = (int)(elapsedTime % 60);

            // Format time as MM:SS
            timerText.text = $"{minutes:00}:{seconds:00}";
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}*/

/* lasttttttttt
using System.Collections;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Reference to TextMeshPro - Text component
    private float startTime;
    private bool isRunning = false;

    private void Start()
    {
        if (timerText == null)
        {
            Debug.LogError("Timer Text reference is not set!");
            return;
        }

        startTime = Time.time;
        isRunning = true;
        Debug.Log("Timer started.");
    }

    private void Update()
    {
        if (isRunning && timerText != null)
        {
            float elapsedTime = Time.time - startTime;

            // Calculate minutes and seconds
            int minutes = (int)(elapsedTime / 60);
            int seconds = (int)(elapsedTime % 60);

            // Format time as MM:SS
            timerText.text = $"{minutes:00}:{seconds:00}";
        }
    }

    public void StopTimer()
    {
        isRunning = false;
        Debug.Log("StopTimer method called. Timer should stop now.");
    }
}*/

/* asliiiiiiii
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Reference to TextMeshPro - Text component
    private float startTime;
    private bool keepTiming;
    private float timer;

    void Start()
    {
        StartTimer();
    }

    void Update()
    {
        if (keepTiming)
        {
            UpdateTime();
        }
    }

    void UpdateTime()
    {
        timer = Time.time - startTime;
        timerText.text = TimeToString(timer);
        Debug.Log("Timer text updated: " + timerText.text); // Debug log
    }

    public float StopTimer()
    {
        keepTiming = false;
        timerText.text = TimeToString(timer); // Stoplandiktan sonra da metni guncelle
        Debug.Log("StopTimer method called. Timer should stop now.");
        return timer;
    }

    public void ResumeTimer()
    {
        keepTiming = true;
        startTime = Time.time - timer;
    }

    public void StartTimer()
    {
        keepTiming = true;
        startTime = Time.time;
    }

    string TimeToString(float t)
    {
        int minutes = (int)(t / 60);
        float seconds = t % 60;
        return $"{minutes:00}:{seconds:00}";
    }
}
*/

using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Reference to TextMeshPro - Text component
    private float startTime;
    private bool keepTiming;
    private float timer;

    void Start()
    {
        // Timer'i otomatik olarak baslatmak istemiyorsaniz bu satiri yoruma alin
        StartTimer();
    }

    void Update()
    {
        if (keepTiming)
        {
            UpdateTime();
        }
        else
        {
            //Debug.Log("Timer is stopped."); // Timer durdugunda mesaj yazdrir
        }
    }

    void UpdateTime()
    {
        timer = Time.time - startTime;
        timerText.text = TimeToString(timer);
        //Debug.Log("Timer text updated: " + timerText.text); // Debug log
    }

    public float StopTimer()
    {
        keepTiming = false;
        timerText.text = TimeToString(timer); // Stoplandiktan sonra da metni guncelle
        Debug.Log("StopTimer method called. Timer should stop now. Current Time: " + timerText.text);
        return timer;
    }

    public void ResumeTimer()
    {
        keepTiming = true;
        startTime = Time.time - timer;
    }

    public void StartTimer()
    {
        keepTiming = true;
        startTime = Time.time;
    }

    string TimeToString(float t)
    {
        int minutes = (int)(t / 60);
        float seconds = t % 60;
        return $"{minutes:00}:{seconds:00}";
    }
}





