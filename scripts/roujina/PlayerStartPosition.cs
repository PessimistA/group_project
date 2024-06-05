using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPosition : MonoBehaviour
{
    public Transform startPoint;  // Başlangıç noktasını temsil eden Transform

    void Start()
    {
        // Karakteri başlangıç noktasına yerleştirme
        if (startPoint != null)
        {
            transform.position = startPoint.position;
            transform.rotation = startPoint.rotation;
        }
        else
        {
            Debug.LogError("Start Point is not assigned!");
        }
    }
}
