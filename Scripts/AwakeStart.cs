using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeStart : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake() has been called.");
    }
    void Start()
    {
        Debug.Log("Start() has also been called.");
    }
}
