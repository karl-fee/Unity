using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour
{
    public float smoothing = 0.5f;
    Vector3 posOne;
    Vector3 posTwo = new Vector3(0, 0, 5);
    void Start()
    {
        posOne = transform.position;
        Debug.Log($"Delta time is {Time.deltaTime}.");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, posTwo, Time.deltaTime * smoothing);
    }
}
