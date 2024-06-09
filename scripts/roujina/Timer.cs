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





