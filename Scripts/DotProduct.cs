using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProduct : MonoBehaviour
{
    Vector3 firstVector = new Vector3(-1, 0, 1);
    Vector3 secondVector = new Vector3(0, 1, 0);

   void Start() {
    float dotProduct = Vector3.Dot(firstVector, secondVector);
    Debug.Log(dotProduct);
   }
}
