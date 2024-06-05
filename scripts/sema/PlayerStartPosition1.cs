
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPosition1 : MonoBehaviour
{
    public Transform startPoint;  // Baslangic noktasini temsil eden Transform

    void Start()
    {
        // Karakteri baslangic noktasina yerlestirme
        if (startPoint != null)
        {
            transform.position = startPoint.position;
            transform.rotation = startPoint.rotation;
        }
        else
        {
            Debug.LogError("Start Point is not assigned");
        }
    }
}